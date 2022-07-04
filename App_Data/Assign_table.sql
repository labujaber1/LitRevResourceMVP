/*
   24 June 202217:44:26
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
ALTER TABLE dbo.Module_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Module_table', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Assign_table
	(
	Assign_IdNum int NOT NULL,
	Assign_Name varchar(100) NOT NULL,
	Assign_DueDate date NULL,
	Assign_Trimester int NULL,
	Mod_IdNum int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Assign_table ADD CONSTRAINT
	PK_Assign_table PRIMARY KEY CLUSTERED 
	(
	Assign_IdNum
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Assign_table ADD CONSTRAINT
	FK_Assign_table_Module_table FOREIGN KEY
	(
	Mod_IdNum
	) REFERENCES dbo.Module_table
	(
	Mod_IdNum
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Assign_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'CONTROL') as Contr_Per 