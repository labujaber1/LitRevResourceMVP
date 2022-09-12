
-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE GetModuleNames
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Mod_Name from Module_table
END
