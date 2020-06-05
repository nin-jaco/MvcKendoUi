CREATE TABLE [dbo].[UserRole]
(
	[RoleID] int NOT NULL
		constraint FK_UserRole_Role_RoleID foreign key (RoleID) references [Role](RoleID),
	[UserID] int NOT NULL
		constraint FK_UserRole_User_UserID foreign key (UserID) references [User](UserID),
	primary key([RoleID],[UserID])
)

