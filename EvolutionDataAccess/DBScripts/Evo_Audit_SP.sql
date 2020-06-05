USE [BMM]
GO

CREATE PROC [dbo].[Evo_Audit_Insert]
	@AuditType nvarchar(100)
	,@AuditDate datetime
	,@OldValue nvarchar(400)
	,@NewValue nvarchar(400)
	,@IPAddress nvarchar(100)
	,@UserAgentString nvarchar(400)
	,@ChangeByUserID nvarchar(50)
	,@ChangeByFullName nvarchar(300)
	AS

	BEGIN
		INSERT INTO [dbo].[Audit]
				   ([AuditType]
				   ,[AuditDate]
				   ,[OldValue]
				   ,[NewValue]
				   ,[IPAddress]
				   ,[UserAgentString]
				   ,[ChangeByUserID]
				   ,[ChangeByFullName])
			 VALUES
				   (@AuditType
				   ,@AuditDate
				   ,@OldValue
				   ,@NewValue
				   ,@IPAddress
				   ,@UserAgentString
				   ,@ChangeByUserID
				   ,@ChangeByFullName)
	END
GO


