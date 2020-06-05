CREATE TABLE [dbo].[User]
(
	[UserID] int identity(1,1) NOT NULL primary key,
	[UserName] nvarchar(50) NOT NULL,
	[Password] nvarchar(100) NULL,
	[Email] nvarchar(50) NULL,
	[Mobile] nvarchar(100) NULL,
	[IsApproved] bit NULL,
	[IsLockedOut] bit NULL,
	[IsOnline] bit NULL,
	[CreateDate] DateTime NULL,
	[LastActivityDate] DateTime NULL,
	[LastLockoutDate] DateTime NULL,
	[LastLoginDate] DateTime NULL,
	[LastPasswordChangedDate] DateTime NULL,
	[PasswordQuestion] nvarchar(400) NULL,
	[Comment] nvarchar(400) NULL
)