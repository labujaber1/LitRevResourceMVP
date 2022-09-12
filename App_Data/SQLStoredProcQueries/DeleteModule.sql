-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE DeleteModule
	@modidnum int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Module_table 
	WHERE Mod_IdNum=@modidnum

END

