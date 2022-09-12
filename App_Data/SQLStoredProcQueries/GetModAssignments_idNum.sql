SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE GetModAssignments_idNum
(@idNum int)
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Assignment_table
	WHERE Mod_IdNum = @idNum
END
GO

