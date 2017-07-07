CREATE PROCEDURE [dbo].[usp_GetUsers]
	@param1 int = 0,
	@param2 int = 0
AS
	SELECT UserName, UserSalt, Password
	FROM tbl_User
RETURN 0
