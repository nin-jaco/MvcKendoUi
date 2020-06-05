CREATE TABLE [dbo].[Role]
(
	[RoleID] int identity(1,1) NOT NULL primary key,
	[RoleName] nvarchar(100) NOT NULL,
	[Active] bit NULL,
	[CreateDate] DateTime NULL,
)
