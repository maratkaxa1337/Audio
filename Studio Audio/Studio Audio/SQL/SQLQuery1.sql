CREATE DATABASE [dbaudio]

USE [dbaudio]

GO

CREATE TABLE [Role] (

[RoleID]	NCHAR(1)		NOT NULL,
[Title]		NVARCHAR(50)	NOT NULL,
CONSTRAINT PK_Role_RoleID PRIMARY KEY ([RoleID])


)

GO
INSERT [Role]([RoleID],[Title]) VALUES ('A','Администратор')
INSERT [Role]([RoleID],[Title]) VALUES ('U', 'Пользователь')

CREATE TABLE [SignIn] (

[ID]			INT IDENTITY (0, 1),
[Username]		NVARCHAR(50)			NOT NULL,
[Password]		NVARCHAR(50)			NOT NULL,
[IDRole]	NCHAR(1) CONSTRAINT FK_SignIn_IDRole_Role_RoleID FOREIGN KEY REFERENCES [Role] ([RoleID])
CONSTRAINT PK_SignIn_ID PRIMARY KEY ([ID])

)

GO
INSERT [SignIn]([Username],[Password],[IDRole]) VALUES ('maratkaxa', '1234', 'A')
INSERT [SignIn]([Username],[Password],[IDRole]) VALUES ('maratakxa1','4321','U')

SELECT * FROM [SignIn]