USE [BMM]
GO

CREATE PROC [dbo].[Evo_Areas_Insert]
	@OrganisationID int,
	@AreaName varchar(25),
	@Telephone varchar(15),
	@EmergencyNumber varchar(15),
	@Mobile varchar(15),
	@EmployeeID int,
	@Total_staff_Allocted int,
	@Total_Engineers_Allocated int,
	@Total_Vehicles_Allocated int
	AS

	BEGIN
		INSERT INTO [dbo].[Areas]
           ([OrganisationID]
           ,[AreaName]
           ,[Telephone]
           ,[EmergencyNumber]
           ,[Mobile]
           ,[EmployeeID]
           ,[Total_staff_Allocted]
           ,[Total_Engineers_Allocated]
           ,[Total_Vehicles_Allocated])
     VALUES
           (@OrganisationID,
            @AreaName,
            @Telephone,
            @EmergencyNumber,
            @Mobile,
            @EmployeeID,
            @Total_staff_Allocted,
            @Total_Engineers_Allocated,
            @Total_Vehicles_Allocated)
	END
GO

CREATE PROC [dbo].[Evo_Areas_Update]
	@AreaID int,
	@OrganisationID int,
	@AreaName varchar(25),
	@Telephone varchar(15),
	@EmergencyNumber varchar(15),
	@Mobile varchar(15),
	@EmployeeID int,
	@Total_staff_Allocted int,
	@Total_Engineers_Allocated int,
	@Total_Vehicles_Allocated int
	AS

	BEGIN
		UPDATE [dbo].[Areas]
		   SET [OrganisationID]				= @OrganisationID
			  ,[AreaName]					= @AreaName
			  ,[Telephone]					= @Telephone
			  ,[EmergencyNumber]			= @EmergencyNumber
			  ,[Mobile]						= @Mobile
			  ,[EmployeeID]					= @EmployeeID
			  ,[Total_staff_Allocted]		= @Total_staff_Allocted
			  ,[Total_Engineers_Allocated]	= @Total_Engineers_Allocated
			  ,[Total_Vehicles_Allocated]	= @Total_Vehicles_Allocated
		 WHERE AreaID = @AreaID
	END
GO

CREATE PROC [dbo].[Evo_Areas_Delete]
	@areaID int
	AS

	BEGIN
		DELETE FROM [dbo].[Areas] WHERE AreaID = @areaID
	END
GO

