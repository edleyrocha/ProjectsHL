SQLite 
SQLServer
MySQL
Access
Oracle


CREATE TABLE [DatabaseListNames](
    [DBList_ID] INTEGER PRIMARY KEY AUTOINCREMENT, 
    [DBList_Name] NVARCHAR(10) NOT NULL, 
    [DBList_DescEN] NVARCHAR(50) NOT NULL, 
    [DBList_DescBR ] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [UQ_DBList_Name] UNIQUE([DBList_Name] ASC), 
    CONSTRAINT [UQ_DBList_DescEN] UNIQUE([DBList_DescEN] ASC), 
    CONSTRAINT [UQ_DBList_DescBR] UNIQUE([DBList_DescBR ] ASC));

CREATE UNIQUE INDEX [DatabaseListNames_IN_DBList_ID]
ON [DatabaseListNames](
    [DBList_ID]);
