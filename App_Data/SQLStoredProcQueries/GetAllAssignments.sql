SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- By LAJ, on 02/08/2022, for LitrevresourceDB
CREATE PROCEDURE GetAllAssignments
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Assignment_table
END
GO

