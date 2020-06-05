Create PROC Evo_memSaveOrganisations
	@OrganisationID [int], 
	@OrganisationName [varchar](50),
	@CompanyNumber [varchar](255) ,
	@TaxNumber [varchar](255) ,
	@OrganisationTypeID [int],
	@OrganisationSubTypeID [int] ,
	@ParentID [int] ,
	@MaximumMachines [int] ,
	@JurisdictionID [int] ,
	@TelephoneCode [varchar](50) ,
	@TelephoneNumber [varchar](50) ,
	@FaxCode [varchar](50) ,
	@FaxNumber [varchar](50) ,
	@ContactName [varchar](50) ,
	@EmailAddress [varchar](50) ,
	@WebSiteURL [varchar](50) ,
	@Longitude [float] ,
	@Latitude [float] ,
	@OrganisationStatusID [int]
as
if (@OrganisationID =0)
begin
	INSERT INTO Organisations(OrganisationName, CompanyNumber,TaxNumber,OrganisationTypeID,
		OrganisationSubTypeID,ParentID,MaximumMachines,JurisdictionID,TelephoneCode,TelephoneNumber,
		FaxCode, FaxNumber,ContactName,EmailAddress,WebSiteURL,Longitude,Latitude,DateAdded,OrganisationStatusID)
	Values (@OrganisationName, @CompanyNumber,@TaxNumber,@OrganisationTypeID,
		@OrganisationSubTypeID,@ParentID,@MaximumMachines,@JurisdictionID,@TelephoneCode,@TelephoneNumber,
		@FaxCode, @FaxNumber,@ContactName,@EmailAddress,@WebSiteURL,@Longitude,@Latitude,GetDate(),@OrganisationStatusID)

		SELECT @OrganisationID = @@IDENTITY
		EXEC sp_BuildOrgTree
end
else
begin
	Update Organisations set OrganisationName=@OrganisationName,CompanyNumber=@CompanyNumber,TaxNumber=@TaxNumber,OrganisationTypeID=@OrganisationTypeID,
	OrganisationSubTypeID =@OrganisationSubTypeID,ParentID=@ParentID,MaximumMachines=@MaximumMachines,JurisdictionID=@JurisdictionID,TelephoneCode=@TelephoneCode,
	TelephoneNumber =@TelephoneNumber,FaxCode=@FaxCode, FaxNumber=@FaxNumber,ContactName=@ContactName,EmailAddress=@EmailAddress,WebSiteURL=@WebSiteURL,
	Longitude=@Longitude,Latitude=@Latitude,OrganisationStatusID=@OrganisationStatusID
	where OrganisationID = @OrganisationID

	DECLARE @PreviousOrganisationName varchar(50)
	DECLARE @PreviousOrganisationTypeID int
	DECLARE @PreviousOrganisationSubTypeID int
	DECLARE @PreviousParentID int
	DECLARE @PreviousJurisdictionID int
	DECLARE @PreviousOrganisationStatusID int
	DECLARE @PreviousContactName varchar(50)

	SELECT @PreviousOrganisationName = OrganisationName, @PreviousOrganisationTypeID = OrganisationTypeID, @PreviousOrganisationSubTypeID = OrganisationSubTypeID, @PreviousParentID = ParentID, @PreviousJurisdictionID = JurisdictionID, @PreviousOrganisationStatusID = OrganisationStatusID, @PreviousContactName = ContactName
	FROM Organisations WHERE OrganisationID = @OrganisationID

	/* Note that we only rebuild the tree after performing the update above */
	IF @PreviousOrganisationName <> @OrganisationName OR
	    @PreviousOrganisationTypeID <> @OrganisationTypeID OR
	    @PreviousOrganisationSubTypeID <> @OrganisationSubTypeID OR
	    @PreviousParentID <> @ParentID OR
	    @PreviousJurisdictionID <> @JurisdictionID OR
	    @PreviousOrganisationStatusID <> @OrganisationStatusID OR
	    @PreviousContactName <> @ContactName
	BEGIN		
		EXEC sp_BuildOrgTree
	END
end
GO
 --select Timestamp()
 --select CURRENT_TIMESTAMP
 --Update Organisations set [Timestamp

CREATE PROCEDURE Evo_memGetOrganisation
	@OrganisationID int
AS
BEGIN
	select * from Organisations where OrganisationID = @OrganisationID
END
GO

CREATE PROCEDURE Evo_memMarkOrganisationAsDeleted
	@OrganisationID int
AS
BEGIN
	Update Organisations set OrganisationStatusID=3 where OrganisationID = @OrganisationID
END
GO

Create Proc Evo_memGetOrganisationTypes
As
 Select * from OrganisationTypes order by [OrganisationTypeName]
GO

Create Proc Evo_memGetOrganisationSubTypes
As
	Select * from [dbo].[OrganisationSubTypes] order by [OrganisationSubTypeName]
GO

Create Proc Evo_memGetOrganisations
as
select * from Organisations order by [OrganisationName]
GO

Create Proc Evo_memGetJurisdictions
as
Select * from [dbo].[Jurisdictions] order by  [JurisdictionName]
GO


Create Proc Evo_memGetOrganisationStatuses
as
 select * from [dbo].[OrganisationStatus] order by [OrganisationStatusName]
GO

Create Proc Evo_memGetOrganisations_SkipTake
@skip int, @Take int
as
SELECT * FROM Organisations ORDER BY OrganisationName  OFFSET @skip ROWS FETCH NEXT @Take ROWS ONLY;
GO

CREATE proc [dbo].[uspGetOrganisationCount]
	@parentorganisation int = NULL,
	@organisation varchar(50) = NULL,
	@childto int = NULL,
	@type int = NULL,
	@subtype int = NULL,
	@jurisdiction int = NULL
as

BEGIN
	IF (@organisation = '')
	BEGIN
		select 
			COUNT(*) as [Count]
		from
			Organisations o
		left join
			OrganisationStatus os
		on
			o.OrganisationStatusID = os.OrganisationStatusID
		--where
		--	o.OrganisationName like '%'+@organisation+'%'
		--and
		--	o.Child = ''
		--and
		--	o.OrganisationTypeID = 1
		--and
		--	o.OrganisationSubTypeID = 1
		--and
		--	o.JurisdictionID = 1
	END
	ELSE
	BEGIN
		select 
			COUNT(*) as [Count]
		from
			Organisations o
		left join
			OrganisationStatus os
		on
			o.OrganisationStatusID = os.OrganisationStatusID
		where
			o.OrganisationName like '%'+@organisation+'%'
		--and
		--	o.Child = ''
		--and
		--	o.OrganisationTypeID = 1
		--and
		--	o.OrganisationSubTypeID = 1
		--and
		--	o.JurisdictionID = 1
	END
END

go

CREATE proc [dbo].[uspGetOrganisation]
	@parentorganisation int = NULL,
	@organisation varchar(50) = NULL,
	@childto int = NULL,
	@type int = NULL,
	@subtype int = NULL,
	@jurisdiction int = NULL,
	@skip int,
	@take int
as

BEGIN
	IF (@organisation = '')
	BEGIN
		SELECT    OrganisationID, OrganisationName, CompanyNumber, TelephoneNo, 
				  ContactName, WebSiteURL, DateAdded, DateDeleted, OrganisationStatusName 
		FROM
		(
			SELECT    ROW_NUMBER() OVER(ORDER BY o.OrganisationID) NUM,
					  o.OrganisationID, o.OrganisationName, o.CompanyNumber, ltrim(rtrim(o.TelephoneCode)) + ltrim(rtrim(o.TelephoneNumber)) as TelephoneNo, 
					  o.ContactName, o.WebSiteURL, o.DateAdded, o.DateDeleted, os.OrganisationStatusName 
			FROM      Organisations o
 			LEFT JOIN OrganisationStatus os
			ON        o.OrganisationStatusID = os.OrganisationStatusID
			--WHERE     o.OrganisationName like '%'+@organisation+'%'
			--AND       o.Child = ''
			--AND       o.OrganisationTypeID = 1
			--AND       o.OrganisationSubTypeID = 1
			--AND       o.JurisdictionID = 1   
		) A
		WHERE NUM > @Skip AND NUM < @Skip + @Take
	END
	ELSE
	BEGIN
		SELECT    OrganisationID, OrganisationName, CompanyNumber, TelephoneNo, 
				  ContactName, WebSiteURL, DateAdded, DateDeleted, OrganisationStatusName 
		FROM
		(
			SELECT    ROW_NUMBER() OVER(ORDER BY o.OrganisationID) NUM,
					  o.OrganisationID, o.OrganisationName, o.CompanyNumber, ltrim(rtrim(o.TelephoneCode)) + ltrim(rtrim(o.TelephoneNumber)) as TelephoneNo, 
					  o.ContactName, o.WebSiteURL, o.DateAdded, o.DateDeleted, os.OrganisationStatusName 
			FROM      Organisations o
 			LEFT JOIN OrganisationStatus os
			ON        o.OrganisationStatusID = os.OrganisationStatusID
			WHERE     o.OrganisationName like '%'+@organisation+'%'
			--AND       o.Child = ''
			--AND       o.OrganisationTypeID = 1
			--AND       o.OrganisationSubTypeID = 1
			--AND       o.JurisdictionID = 1   
		) A
		WHERE NUM > @Skip AND NUM < @Skip + @Take
	END
END
go

CREATE TABLE [dbo].[Audit]
(
	[AuditID] bigint identity(1,1) NOT NULL primary key,
	[AuditType] nvarchar(100) NOT NULL,
	[AuditDate] datetime  NOT NULL,
	[OldValue] nvarchar(400) NOT NULL,
	[NewValue] nvarchar(400) NOT NULL,
	[IPAddress] nvarchar(100) NULL,
	[UserAgentString] nvarchar(400) NULL,
	[ChangeByUserID] nvarchar(50) NOT NULL,
	[ChangeByFullName] nvarchar(300) NOT NULL
)
go

Create Proc [dbo].[evo_BankAccountsSave]
@OrganisationID int, @AccountHolder varchar(max),@AccountNumber varchar(max),
@BankID int,@Branch varchar(max), @BranchCode varchar(max),@AccountTypeID varchar(max)
as

declare @count int=0

set @count = (select count(*) from BankAccounts where OrganisationID =@OrganisationID) -- AccountNumber=@AccountNumber and BankID =@BankID)

if @AccountTypeID=0 set @AccountTypeID =null

if @count=0
Begin
	Insert into BankAccounts(OrganisationID,AccountHolder,AccountNumber,BankID,Branch,BranchCode,AccountTypeID) 
	values (@OrganisationID,@AccountHolder,@AccountNumber,@BankID,@Branch,@BranchCode,@AccountTypeID)
End
Else --@count > 0
Begin
	Update BankAccounts set AccountHolder=@AccountHolder,AccountNumber=@AccountNumber,
	BankID = @BankID,Branch = @Branch,BranchCode=@BranchCode, AccountTypeID=@AccountTypeID
	where OrganisationID =@OrganisationID --AccountNumber=@AccountNumber and BankID =@BankID
End
GO


Create Proc Evo_GetOrganisationBankAccounts
@OrganisationId int
as
select * from [dbo].[BankAccounts] where [OrganisationID] = @OrganisationId
GO

Create Proc Evo_GetBankAccountTypes
as
select * from [dbo].[BankAccountTypes]
GO
  
Create Proc Evo_GetBanks
as
select * from [dbo].[Banks]
GO


Create Proc GetAccountTypes
as
select * from AccountTypes
GO

Create Proc Evo_DailyDeductionsSave
@MachineID int, @ApplicableDate datetime,@RevenueProfileID int, @SiteID int,@CollectionOrganisationID int, @CreditOrganisationID int,@RatePercent real,@Amount money
as
Declare @count int=0
Select @count = (select count(*) from DailyDeductions where MachineID=@MachineID and ApplicableDate=@ApplicableDate and RevenueProfileID=@ApplicableDate and SiteID=@SiteID and CreditOrganisationID=@CreditOrganisationID)
if @count=0
Begin
insert into DailyDeductions(MachineID,ApplicableDate,RevenueProfileID,SiteID,CollectionOrganisationID,CreditOrganisationID,RatePercent,Amount)
values (@MachineID,@ApplicableDate,@RevenueProfileID,@SiteID,@CollectionOrganisationID,@CreditOrganisationID,@RatePercent,@Amount)
End
Else
Begin
	Update DailyDeductions set [CollectionOrganisationID]=@CollectionOrganisationID,RatePercent=@RatePercent,Amount=@Amount where  MachineID=@MachineID and ApplicableDate=@ApplicableDate and RevenueProfileID=@ApplicableDate and SiteID=@SiteID and CreditOrganisationID=@CreditOrganisationID
End
GO

Create Proc Evo_GetDailyDeductions
as
select * from DailyDeductions
GO

Create Proc GetOrgRevenueProfiles
@OrganisationID int, @skip int, @take int
as
Select * from RevenueProfiles where OrganisationID = @OrganisationID order by OrganisationID OFFSET @skip ROWS FETCH NEXT @Take ROWS ONLY;
GO

Create Proc GetRevenueProfileTypes
as
select * from RevenueProfileTypes
GO

Create proc GetDeductionTypes
as
select * from DeductionTypes
GO

Create proc GetDeductionTotalTypes
as
select * from [dbo].[DeductionTotalTypes]
GO

Create Proc Evo_DeleteOrganisationRevenueProfile
@RevenueProfileID int
as
DELETE FROM RevenueScales WHERE RevenueProfileID = @RevenueProfileID
Delete from RevenueProfiles where RevenueProfileID = @RevenueProfileID
GO

Create proc Evo_GetRevenueProfileScales
@profileID int
as
select * from RevenueScales where RevenueProfileID = @profileID
GO

Create Proc Evo_SaveRevenueProfileScale
@RevenueProfileID int, @RevenueScaleID int, @FixedAmount money,@Limit float,@Rate real
as

if @RevenueScaleID =0 --add revenue profile
begin
	declare @lastscaleid int
	select @lastscaleid = (select isnull(max(RevenueScaleID),-1) from RevenueScales where RevenueProfileID =@RevenueProfileID)
		
	set @lastscaleid =@lastscaleid + 1		
	insert RevenueScales(RevenueProfileID,RevenueScaleID,FixedAmount,Limit,Rate,DateAdded) values(@RevenueProfileID,@lastscaleid,@FixedAmount,@Limit,@Rate,GETDATE())
end
else
begin
	Update RevenueScales set FixedAmount=@FixedAmount,Limit=@Limit,Rate=@Rate where RevenueProfileID=@RevenueProfileID and RevenueScaleID= @RevenueScaleID
end
GO

Create Proc Evo_DeleteRevenueProfileScale
@RevenueProfileID int, @RevenueScaleID int
as
Delete RevenueScales where  RevenueProfileID=@RevenueProfileID and RevenueScaleID= @RevenueScaleID
GO


Create PROCEDURE [dbo].[Evo_SaveRevenueProfileSplits]
@RevenueProfileID int OUTPUT,
@RevenueProfileName varchar(50),
@OrganisationID int,
@DeductionTotalTypeID int,
@AppliesOrganisationTypeID int,
@CollectOrganisationTypeID int,
@RevenueProfileTypeID int,
@DeductionTypeID int,
@CreditOrganisationTypeID int,
@IsSplit bit = 1,
@SiteSplit float,
@OperatorSplit float
AS
	/*	
		Could not use sp_SaveRevenueProfile for we have to save revenue splits here. 
		Cann't modify the SP, being used by old system

		This procedure save or updates the RevenueProfile, and deletes out the
		Revenue Scales entries for the Profile. The entries for the Revenue Scales
		are always 
	*/


SELECT @CreditOrganisationTypeID = 	OrganisationTypeID 
					FROM Organisations
					WHERE OrganisationID = @OrganisationID

-- The Site Cannot be the Credit Organisation
IF @CreditOrganisationTypeID = 	4
	SELECT @CreditOrganisationTypeID = 	3


-- The Split must be deducted from NGR
IF @IsSplit = 1
	SELECT @RevenueProfileTypeID = 	6


IF NOT EXISTS (	SELECT RevenueProfileID
				FROM RevenueProfiles
				WHERE RevenueProfileID = @RevenueProfileID
				)
BEGIN
	INSERT INTO RevenueProfiles
		(	RevenueProfileName, 
			OrganisationID, 
			DeductionTotalTypeID, 
			AppliesOrganisationTypeID, 
			CollectOrganisationTypeID, 
			RevenueProfileTypeID, 
			DeductionTypeID,
			CreditOrganisationTypeID,
			IsSplit 
		)
	VALUES(	@RevenueProfileName,
			@OrganisationID,
			@DeductionTotalTypeID,
			@AppliesOrganisationTypeID,
			@CollectOrganisationTypeID,
			@RevenueProfileTypeID,
			@DeductionTypeID,
			@CreditOrganisationTypeID,
			@IsSplit 
			)
	SELECT @RevenueProfileID = @@IDENTITY

END
ELSE
BEGIN
	UPDATE RevenueProfiles
	SET 	RevenueProfileName= @RevenueProfileName,
			OrganisationID= @OrganisationID,
			DeductionTotalTypeID= @DeductionTotalTypeID,
			AppliesOrganisationTypeID= @AppliesOrganisationTypeID,
			CollectOrganisationTypeID= @CollectOrganisationTypeID,
			RevenueProfileTypeID= @RevenueProfileTypeID,
			DeductionTypeID=@DeductionTypeID,
			CreditOrganisationTypeID=@CreditOrganisationTypeID,
			IsSplit=@IsSplit 
	WHERE RevenueProfileID = @RevenueProfileID
	DELETE FROM RevenueScales
	WHERE RevenueProfileID = @RevenueProfileID
END

--insert split into revenue scales
insert into RevenueScales(RevenueProfileID,RevenueScaleID,FixedAmount,Limit,Rate,DateAdded)
values (@RevenueProfileID,0,0,0,@OperatorSplit,GETDATE())
GO

















