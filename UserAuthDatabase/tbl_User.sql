CREATE TABLE [dbo].[tbl_User]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [UserSalt] CHAR(10) NOT NULL, 
    [Password] NCHAR(10) NULL
)
