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
