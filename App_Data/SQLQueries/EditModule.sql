-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE EditModule (
	 @Mod_Name varchar(50),
	 @Mod_DateYear varchar(4),
	 @Mod_IdNum int
	 )
	 
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE Module_table 
	SET Mod_Name=@Mod_Name, Mod_DateYear=@Mod_DateYear 
	WHERE Mod_IdNum=@Mod_IdNum
END