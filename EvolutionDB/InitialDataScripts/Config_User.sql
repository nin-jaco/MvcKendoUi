SET IDENTITY_INSERT [User] ON

INSERT INTO [User]
           ([UserID]
		   ,[UserName]
		   ,[Mobile])
     VALUES
           (1
           ,'John'
		   ,'0821112222')

INSERT INTO [User]
           ([UserID]
		   ,[UserName]
		   ,[Mobile])
     VALUES
           (2
           ,'Louis'
		   ,'0828547594')

SET IDENTITY_INSERT [User] OFF

