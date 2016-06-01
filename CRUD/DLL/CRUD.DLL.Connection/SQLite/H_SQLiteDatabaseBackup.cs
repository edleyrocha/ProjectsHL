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
namespace HOYLER.Data.SQLite
{
    /// <summary>
    /// #H Classe H_SQLiteDatabaseBackup
    /// </summary>
    public class H_SQLiteDatabaseBackup
    {
        /// <summary>
        /// #H Metodo Contrutor da Classe H_SQLiteDatabaseBackup()
        /// </summary>
        public H_SQLiteDatabaseBackup()
        {
        }
        /// <summary>
        /// #H Metodo para BackupDB via Copy
        /// </summary>
        /// <param name="myDataSource"> Patch Source</param>
        /// <param name="myMoveBD">Move or NOT Move</param>
        /// <returns>Retorna string </returns>
        public static string BackupDatabaseCopyDB(String myDataSource, Boolean myMoveBD)
        {
            //String Retorno Padrao
            var myReturn = (String.Empty);
            try
            {
                // Check File (myDataSource) EXIST
                if (!System.IO.File.Exists(myDataSource))
                {
                    /// Check File (myDataSource) NOT EXIST - ERRO
                    throw new System.ArgumentException("Erro File Source Nao Existe (00001)", "Metodo BackupDatabaseCopyDB()");
                }

                //SET Pasta Default para BackupDB
                var BackupDB_Folder = (System.IO.Path.GetDirectoryName(myDataSource));
                BackupDB_Folder = (System.IO.Path.Combine((BackupDB_Folder), (@"BackupDB\")));

                // Criar Diretorio
                System.IO.Directory.CreateDirectory(BackupDB_Folder);

                // Check Directory (\BackupDB) EXIST
                if (!System.IO.Directory.Exists(BackupDB_Folder))
                {
                    // Check Directory (\BackupDB) NOT EXIST - ERRO
                    throw new System.ArgumentException("Erro ao Criar pasta BackupDB (00002)", "Metodo BackupDatabaseCopyDB()");
                }

                //Veriaveis para Backup
                var fileName = (System.IO.Path.GetFileName(myDataSource));
                var patchDiretory = (System.IO.Path.GetDirectoryName(myDataSource));
                var dateNow = (DateTime.Now);

                //Set Format for File
                var DestfileName = (String.Format(("{0}{1}{2}{3}"), (BackupDB_Folder), ("Backup_"), (dateNow.ToString("DATE_dd_MM_yyyy_T_HH_mm_ss_fff_")), (fileName)));

                //Verifica Move(true) 
                //Verifica Copia(false)
                switch (myMoveBD)
                {
                    case (true)://Move
                        {
                            // Move File 
                            System.IO.File.Move((myDataSource), (DestfileName));
                            break;
                        }
                    case (false): //Copy
                        {
                            // Copy File 
                            System.IO.File.Copy((myDataSource), (DestfileName));
                            break;
                        }
                }

                // Check if File Exist
                if (!System.IO.File.Exists(DestfileName))
                {
                    throw new System.ArgumentException("Erro BACKUP nao Encontrado (00003)", "Metodo BackupDatabaseCopyDB()");
                }
                else if (System.IO.File.Exists(DestfileName))
                {
                    myReturn = (String.Format(("{0}"), ("OK")));
                }
            }
            catch (Exception myEx)
            {
                // Retornar Erro
                myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            return (myReturn);
        }
    }
}
