/*
   25 June 202214:14:03
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
ALTER TABLE dbo.Resource_table
	DROP CONSTRAINT FK_Resource_table_Assign_table
GO
ALTER TABLE dbo.Assignment_table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Assignment_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Assignment_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Assignment_table', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Resource_table
	(
	Res_IdNum int NOT NULL IDENTITY (1, 1),
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
ALTER TABLE dbo.Tmp_Resource_table SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Resource_table ON
GO
IF EXISTS(SELECT * FROM dbo.Resource_table)
	 EXEC('INSERT INTO dbo.Tmp_Resource_table (Res_IdNum, Res_Weblink, Res_Type, Res_DateAccessed, Res_Category, Res_Reference, Res_MainPoint, Res_Notes, Assign_IdNum)
		SELECT Res_IdNum, Res_Weblink, Res_Type, Res_DateAccessed, Res_Category, Res_Reference, Res_MainPoint, Res_Notes, Assign_IdNum FROM dbo.Resource_table WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Resource_table OFF
GO
DROP TABLE dbo.Resource_table
GO
EXECUTE sp_rename N'dbo.Tmp_Resource_table', N'Resource_table', 'OBJECT' 
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
	) REFERENCES dbo.Assignment_table
	(
	Assign_IdNum
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Resource_table', 'Object', 'CONTROL') as Contr_Per 