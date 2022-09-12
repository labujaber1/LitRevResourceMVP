-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE AddModule (
	 @modname varchar(50),
	 @moddateyear varchar(4)
	 )
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO Module_table (Mod_Name,Mod_DateYear)
	VALUES (@modname,@moddateyear)
END

