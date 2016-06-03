DROP TABLE IF EXISTS [DatabaseBackup];
DROP TABLE IF EXISTS [DatabaseBackupMode];
DROP TABLE IF EXISTS [DatabaseBackupServer];

CREATE TABLE IF NOT EXISTS[DatabaseBackupServer](
  [DBBackupServer_ID]       integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupServer_Name]     varchar(50) NOT NULL,
  [DBBackupServer_DescBR]   varchar(50) NOT NULL,
  [DBBackupServer_DescEN]   varchar(50) NOT NULL  
);
INSERT INTO [DatabaseBackupServer] ([DBBackupServer_Name], [DBBackupServer_DescBR], [DBBackupServer_DescEN])
VALUES
('SQLite', 'SQLite é um motor de banco de dados SQL embutido', 'SQLite is an embedded SQL database engine'),
('SQLServer', 'SQLServer é um banco de dados SQL Microsoft', 'SQLServer is an SQL database Microsoft'),
('MySQL', 'MySQL é um banco de dados SQL Oracle', 'MySQL is an SQL database Oracle'),
('Access', 'Access é um banco de dados SQL Microsoft', 'Access is an SQL database Microsoft'),
('Oracle', 'Oracle é um banco de dados SQL Oracle', 'Oracle is an SQL database Oracle');
 

CREATE TABLE [DatabaseBackupMode](
  [DBBackupMode_ID]       integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupServer_ID]     integer NOT NULL,
  [DBBackupMode_Name]     nvarchar(50) NOT NULL,
  [DBBackupMode_DescBR]   nvarchar(50) NOT NULL,
  CONSTRAINT [FK_ BackupMode_DBBackupServer_ID] FOREIGN KEY ([DBBackupServer_ID]) REFERENCES [DatabaseBackupServer]([DBBackupServer_ID])
);
CREATE TABLE [DatabaseBackup](
  [DBBackup_ID]           integer PRIMARY KEY AUTOINCREMENT,
  [DBBackupMode_ID]       integer NOT NULL,
  [DBBackup_PatchFile]    nvarchar(50) NOT NULL,
  [DBBackup_PatchBackup]  nvarchar(50) NOT NULL,
  CONSTRAINT [FK_ DBBackup_DBBackupMode_ID] FOREIGN KEY ([DBBackupMode_ID]) REFERENCES [DatabaseBackupMode]([DBBackupMode_ID])
);




