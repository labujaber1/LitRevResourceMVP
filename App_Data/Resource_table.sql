/*
   24 June 202221:21:10
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
ALTER TABLE dbo.Assign_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Assign_table', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Resource_table
	(
	Res_IdNum int NOT NULL,
	Res_Weblink varchar(100) NULL,
	Res_Type varchar(20) NULL,
	Res_DateAccessed date NULL,
	Res_Category varchar(20) NULL,
	Res_Reference varchar(100) NULL,
	Res_MainPoint varchar(2000) NULL,
	Res_Notes varchar(4000) NULL,
	Assign_IdNum int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Resource_table ADD CONSTRAINT
	PK_Resource_table PRIMARY KEY CLUSTERED 
	(
	Res_IdNum
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Resource_table ADD CONSTRAINT
	FK_Resource_table_Assign_table FOREIGN KEY
	(
	Assign_IdNum
	) REFERENCES dbo.Assign_table
	(
	Assign_IdNum
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Resource_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'CONTROL') as Contr_Per 