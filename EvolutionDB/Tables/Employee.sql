CREATE TABLE [dbo].[Employee]
(
	[EmployeeID] int identity(1,1) NOT NULL primary key,
	[EmployeeName] nvarchar(100)  NOT NULL,
	[Status] nvarchar(20) NOT NULL default('Active'),
	[StatusDescription] nvarchar(200) NULL
)
