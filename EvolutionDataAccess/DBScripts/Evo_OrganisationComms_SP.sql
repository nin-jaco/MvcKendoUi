USE [BMM]
GO

CREATE PROC [dbo].[Evo_OrganisationalComms_Insert]
	@OrganisationID int,
	@OrganisationCommTypeID int,
	@Address varchar(50),
	@AddressPrefix varchar(50),
	@CommsHoneymoon smallint
	AS

	BEGIN
		INSERT INTO [dbo].[OrganisationComms]
			   ([OrganisationID]
			   ,[OrganisationCommTypeID]
			   ,[Address]
			   ,[AddressPrefix]
			   ,[CommsHoneymoon])
		 VALUES
			   (@OrganisationID
			   ,@OrganisationCommTypeID
			   ,@Address
			   ,@AddressPrefix
			   ,@CommsHoneymoon)
	END
GO

CREATE PROC [dbo].[Evo_OrganisationalComms_Update]
	@OrganisationCommID int,
	@OrganisationID int,
	@OrganisationCommTypeID int,
	@Address varchar(50),
	@AddressPrefix varchar(50),
	@CommsHoneymoon smallint
	AS

	BEGIN
		UPDATE [dbo].[OrganisationComms]
		   SET [OrganisationID]			= @OrganisationID
			  ,[OrganisationCommTypeID] = @OrganisationCommTypeID
			  ,[Address]				= @Address
			  ,[AddressPrefix]			= @AddressPrefix
			  ,[CommsHoneymoon]			= @CommsHoneymoon
		 WHERE OrganisationCommID		= @OrganisationCommID
	END
GO

CREATE PROC [dbo].[Evo_OrganisationalComms_Delete]
	@OrganisationCommID int
	AS

	BEGIN
		DELETE FROM [dbo].[OrganisationComms] WHERE OrganisationCommID = @OrganisationCommID
	END
GO


