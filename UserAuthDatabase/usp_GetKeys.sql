CREATE PROCEDURE [dbo].[usp_GetKeys]
	@param1 int = 0,
	@param2 int = 0
AS
	SELECT KeyName, KeyValue
	FROM	tbl_Keys
RETURN 0
