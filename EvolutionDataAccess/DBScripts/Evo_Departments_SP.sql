USE [BMM]
GO

CREATE PROC [dbo].[Evo_Departments_Insert]
	@OrganisationID int,
	@DepartmentName varchar(50),
	@DepartmentParentID int
	AS

	BEGIN
		INSERT INTO [dbo].[Departments]
				   ([OrganisationID]
				   ,[DepartmentName]
				   ,[DepartmentParentID])
			 VALUES
				   (@OrganisationID
				   ,@DepartmentName
				   ,@DepartmentParentID)
	END
GO

CREATE PROC [dbo].[Evo_Departments_Update]
	@DepartmentID int,
	@OrganisationID int,
	@DepartmentName varchar(50),
	@DepartmentParentID int
	AS

	BEGIN
		UPDATE [dbo].[Departments]
			SET [OrganisationID]		= @OrganisationID
				,[DepartmentName]		= @DepartmentName
				,[DepartmentParentID]	= @DepartmentParentID
			WHERE DepartmentID = @DepartmentID
	END
GO

CREATE PROC [dbo].[Evo_Departments_Delete]
	@DepartmentID int
	AS

	BEGIN
		DELETE FROM [dbo].[Departments] WHERE DepartmentID = @DepartmentID
	END
GO


