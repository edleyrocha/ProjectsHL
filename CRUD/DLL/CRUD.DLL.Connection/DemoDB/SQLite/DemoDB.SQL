DROP TABLE IF EXISTS [DatabaseBackup];
DROP TABLE IF EXISTS [DatabaseBackupMode];
DROP TABLE IF EXISTS [DatabaseBackupServer];

CREATE TABLE IF NOT EXISTS [DatabaseBackupServer](
  [DBBackupServer_ID]       integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupServer_Name]     nvarchar(50) NOT NULL,
  [DBBackupServer_DescBR]   nvarchar(50) NOT NULL,
  [DBBackupServer_DescEN]   nvarchar(50) NOT NULL  
);

CREATE TABLE IF NOT EXISTS [DatabaseBackupMode](
  [DBBackupMode_ID]       integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupServer_ID]     integer NOT NULL,
  [DBBackupMode_Name]     nvarchar(50) NOT NULL,
  [DBBackupMode_DescBR]   nvarchar(50) NOT NULL,
  CONSTRAINT [FK_ BackupMode_DBBackupServer_ID] FOREIGN KEY ([DBBackupServer_ID]) REFERENCES [DatabaseBackupServer]([DBBackupServer_ID])
 );
 
CREATE TABLE IF NOT EXISTS [DatabaseBackup](
  [DBBackup_ID]           integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupMode_ID]       integer NOT NULL,
  [DBBackup_PatchFile]    nvarchar(255) NOT NULL,
  [DBBackup_PatchBackup]  nvarchar(255) NOT NULL,
  [DBBackup_Date] DATETIME NOT NULL DEFAULT (DATETIME ('now', 'localtime')), 
  CONSTRAINT [FK_ DBBackup_DBBackupMode_ID] FOREIGN KEY ([DBBackupMode_ID]) REFERENCES [DatabaseBackupMode]([DBBackupMode_ID])
);
/*

*INSERT DatabaseBackupServer *

SELECT * FROM [DatabaseBackupServer];

*/
INSERT INTO [DatabaseBackupServer] ([DBBackupServer_Name], [DBBackupServer_DescBR], [DBBackupServer_DescEN])
VALUES
('Access', 'Access é um banco de dados SQL Microsoft Office.', 'Access is an SQL database Microsoft Office.'),
('MySQL', 'MySQL é um banco de dados SQL Oracle.', 'MySQL is an SQL database Oracle.'),
('Oracle', 'Oracle é um banco de dados SQL Oracle.', 'Oracle is an SQL database Oracle.'),
('SQLite', 'SQLite é um motor de banco de dados SQL embutido.', 'SQLite is an embedded SQL database engine.'),
('SQLServer', 'SQLServer é um banco de dados SQL Microsoft.', 'SQLServer is an SQL database Microsoft.');

/*

*INSERT DatabaseBackupMode *

INSERT INTO [DatabaseBackupMode] ([DBBackupServer_ID], [DBBackupMode_Name], [DBBackupMode_DescBR])
VALUES
(4, 'Move', 'Move Arquivo para Pasta Backup'),
(4, 'Copy', 'Copia Arquivo para Pasta Backup'),
(4, 'Backup', 'Cria Backup para Pasta Backup');

SELECT * FROM [DatabaseBackupMode];

*/
INSERT INTO [DatabaseBackupMode] ([DBBackupServer_ID], [DBBackupMode_Name], [DBBackupMode_DescBR])
SELECT [DBBackupServer_ID] AS [DBBackupServer_ID], 'Move' AS [DBBackupMode_Name], 'Move Arquivo para Pasta Backup'AS [DBBackupMode_DescBR] from [DatabaseBackupServer] WHERE [DBBackupServer_Name] = 'SQLite';
INSERT INTO [DatabaseBackupMode] ([DBBackupServer_ID], [DBBackupMode_Name], [DBBackupMode_DescBR])
SELECT [DBBackupServer_ID] AS [DBBackupServer_ID], 'Copy' AS [DBBackupMode_Name], 'Copia Arquivo para Pasta Backup'AS [DBBackupMode_DescBR] from [DatabaseBackupServer] WHERE [DBBackupServer_Name] = 'SQLite';
INSERT INTO [DatabaseBackupMode] ([DBBackupServer_ID], [DBBackupMode_Name], [DBBackupMode_DescBR])
SELECT [DBBackupServer_ID] AS [DBBackupServer_ID], 'Backup' AS [DBBackupMode_Name], 'Cria Backup para Pasta Backup'AS [DBBackupMode_DescBR] from [DatabaseBackupServer] WHERE [DBBackupServer_Name] = 'SQLite';

 
