#region Copyright and License Information
/**
 *
 *            <git hub="https://github.com/edleyrocha">
 *                GitHub Repositories
 *            </git>
 *            <mail address="contato@hoyler.com.br">
 *                Developer Email
 *            </mail>
 *            <copyright company="HOYLER Tecnologia">
 *                Copyright (c) HOYLER Tecnologia. All rights reserved.
 *            </copyright>
 *
**/
#endregion
using System;
using System.IO;
using System.Data.SQLite;
namespace HOYLER.Data.SQLite
{
    /// <summary>
    /// #H Classe H_SQLiteBackup
    /// </summary>
    public class H_SQLiteBackup
    {
        /// <summary>
        /// #H Metodo Construtor H_SQLiteBackup()
        /// </summary>
        public H_SQLiteBackup()
        {
        }
        public enum EscolhaTipo
        {
            Move = 0,
            Copy = 1,
            Backup = 2
        };
        public static string BackupDB(String myDataSource, EscolhaTipo myExecTipo, String myPassword = "")
        {
            // String Retorno Padrao
            var myReturn = (String.Empty);
            try
            {
                // Check File EXIST
                if (!File.Exists(myDataSource))
                {
                    // File NOT EXIST - ERRO
                    throw new ArgumentException("Erro File Source Nao Existe (00001)", "Metodo BackupDB()");
                };

                //Backup Folder Destination
                var backupFolderDestination = (Path.GetDirectoryName(myDataSource));
                backupFolderDestination = (Path.Combine((backupFolderDestination), (@"BackupDB\")));
                // Check Backup Folder Destination EXIST
                if (!Directory.Exists(backupFolderDestination))
                {
                    // Criar Backup Folder Destination
                    Directory.CreateDirectory(backupFolderDestination);
                    // Check Backup Folder Destination EXIST
                    if (!Directory.Exists(backupFolderDestination))
                    {
                        // Backup Folder Destination NOT EXIST - ERRO
                        throw new ArgumentException("Erro ao Criar pasta BackupDB (00002)", "Metodo BackupDB()");
                    };
                };

                // Source File Name
                var sourceFileName = (Path.GetFileName(myDataSource));
                // Source Diretory Name
                var sourcePatchDiretory = (Path.GetDirectoryName(myDataSource));
                // Date NOW
                var dateNow = (DateTime.Now);
                //Destination File Name
                var destinationFileName = (String.Format(("{0}{1}{2}{3}"), (backupFolderDestination), ("Backup_"), (dateNow.ToString("DATE_dd_MM_yyyy_T_HH_mm_ss_fff_")), (sourceFileName)));
                // Check File EXIST
                if (File.Exists(destinationFileName))
                {
                    /// Check File (myDataSource) EXIST - ERRO
                    throw new ArgumentException("Erro File Destino já Existe (00003)", "Metodo BackupDB()");
                };

                switch (myExecTipo)
                {
                    case (EscolhaTipo.Move):
                        {
                            // Move File 
                            File.Move((myDataSource), (destinationFileName));
                            break;
                        };
                    case (EscolhaTipo.Copy):
                        {
                            // Copy File 
                            File.Copy((myDataSource), (destinationFileName));
                            break;
                        };
                    case (EscolhaTipo.Backup):
                        {
                            var myPasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes(myPassword));
                            var StringBuilderSource = new H_SQLiteConnectionStringBuilder()
                            {
                                @SetStringBuilder1_DataSource = (myDataSource),
                                @SetStringBuilder2_HexPassword = (myPasswdHex),
                                @SetStringBuilder4_ReadOnly = (true)
                            };
                            var StringBuilderDestination = new H_SQLiteConnectionStringBuilder()
                            {
                                @SetStringBuilder1_DataSource = (destinationFileName),
                                @SetStringBuilder2_HexPassword = (myPasswdHex),
                                @SetStringBuilder3_FailIfMissing = (false)
                            };
                            using (var SQLiteConnSource = (new System.Data.SQLite.SQLiteConnection(StringBuilderSource.GetStringBuilder.ConnectionString)))
                            {
                                using (var SQLiteConnDestination = (new System.Data.SQLite.SQLiteConnection(StringBuilderDestination.GetStringBuilder.ConnectionString)))
                                {
                                    SQLiteConnSource.Open();
                                    SQLiteConnDestination.Open();
                                    SQLiteConnSource.BackupDatabase(SQLiteConnDestination, "main", "main", -1, null, 0);
                                };
                            };
                            break;
                        };
                };
                // Check if File NOT Exist or Exist
                if (!File.Exists(destinationFileName))
                {
                    throw new ArgumentException("Erro BACKUP nao Encontrado (00004)", "Metodo BackupDB()");
                }
                else if (File.Exists(destinationFileName))
                {
                    myReturn = (String.Format(("{0}"), ("OK")));
                };
            }
            catch (Exception myEx)
            {
                // Retornar Erro
                myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            };
            return (myReturn);
        }
    }
}
