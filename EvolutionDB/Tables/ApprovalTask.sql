CREATE TABLE [dbo].[ApprovalTask]
(
	[ApprovalTaskID] bigint identity(1,1) NOT NULL primary key,
	[ApprovalTypeID] [uniqueidentifier] NOT NULL,
	--[ApprovalID] int NOT NULL
	--	constraint FK_ApprovalTask_Approval_ApprovalID foreign key ([ApprovalID]) references Approval(ApprovalID),
	[AssignedToUserID] [int] NOT NULL
		constraint FK_ApprovalTask_User_AssignedTo foreign key ([AssignedToUserID]) references [User](UserID),
	[AssignedToRoleName] [nvarchar](100) NOT NULL,
	[CreatedByUserID] [int] NULL
		constraint FK_ApprovalTask_User_CreatedBy foreign key ([CreatedByUserID]) references [User](UserID),
	[ActionedByUserID] [int] NULL
		constraint FK_ApprovalTask_User_ActionedBy foreign key ([ActionedByUserID]) references [User](UserID),
	[ActionType] [nvarchar](100) NOT NULL,
	[ApprovalStage] [nvarchar](100) NOT NULL,
	[Status] [nvarchar](100) NOT NULL,
	[AssignedDate] [datetime] NOT NULL,
	[ActionedDate] [datetime] NULL,
	[ExpiryDate] [date] NULL,
	[ReminderFrequency] [int] NOT NULL,
	[NextReminderDate] [date] NULL,
	[Outcome] [nvarchar](400) NULL,
	[OutcomeNote] [nvarchar](400) NULL,
	[OutcomeStartDate] [date] NULL,
	[OutcomeEndDate] [date] NULL,
)