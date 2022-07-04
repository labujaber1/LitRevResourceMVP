/*
   23 June 202218:59:54
   User: 
   Server: (local)\SQLEXPRESS
   Database: LitrevresourceDB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Module_table
	(
	Mod_IdNum int NOT NULL,
	Mod_Name varchar(50) NOT NULL,
	Mod_DateYear varchar(4) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Module_table ADD CONSTRAINT
	PK_Module_table PRIMARY KEY CLUSTERED 
	(
	Mod_IdNum
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Module_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'CONTROL') as Contr_Per 