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
    /// # Classe SQLiteDatabaseBackup
    /// </summary>
    public class SQLiteDatabaseBackup
    {
        /// <summary>
        /// # Metodo Contrutor da Classe SQLiteDatabaseBackup()
        /// </summary>
        public SQLiteDatabaseBackup()
        {
        }
        public void BackupDatabaseDumpDB()
        {
        }
        /// <summary>
        /// # Metodo para BackupDB via Copy
        /// </summary>
        /// <param name="myDataSource"> Patch Source</param>
        /// <param name="myMoveBD">Move or NOT Move</param>
        /// <returns>Retorna string </returns>
        public static string BackupDatabaseCopyDB(String myDataSource, Boolean myMoveBD)
        {
            ///String Retorno Padrao
            var myReturn = (String.Empty);

            ///Criar Pasta Default para Backup
            var backupFolderDefault = (System.IO.Path.GetDirectoryName(myDataSource));
            backupFolderDefault = (System.IO.Path.Combine((backupFolderDefault), (@"BackupDB\")));

            // Check se Diretorio Existe
            if (!System.IO.Directory.Exists(backupFolderDefault))
            {
                try
                {
                    // Criar Diretorio
                    System.IO.Directory.CreateDirectory(backupFolderDefault);

                    // Check se Diretorio Existe
                    if (!System.IO.Directory.Exists(backupFolderDefault))
                    {
                        //Gerando Erro pois diretorio nao foi criado
                        throw new System.ArgumentException("Erro ao Criar Pasta BackupDB (Gerado por IF)", "Metodo BackupDatabaseCopyDB()");
                    }
                }
                catch (Exception myEx)
                {
                    // Retornar Erro
                    myReturn = String.Format(("Erro ao Criar Pasta BackupDB:\n{0}\n{1}"), (backupFolderDefault), (myEx.ToString()));
                    return myReturn;
                }
            }

            ///Veriaveis para Backup
            var fileName = System.IO.Path.GetFileName(myDataSource);
            var patchDiretory = System.IO.Path.GetDirectoryName(myDataSource);
            var dt = (DateTime.Now);

            try
            {
                ///Verifica Move ou Copia Arquivo atual
                switch (myMoveBD)
                {
                    case (true):
                        {
                            if (System.IO.File.Exists(myDataSource))
                            {
                                var DestfileName = (String.Format(("{0}{1}{2}{3}"), (backupFolderDefault), ("Backup_"), (dt.ToString("DATE_dd_MM_yyyy_T_HH_mm_ss_fff_")), (fileName)));
                                System.IO.File.Move((myDataSource), (DestfileName));
                                myReturn = (String.Format(("{0}"), ("OK")));
                            }
                            else
                            {
                                throw new System.ArgumentException("Erro Arquivo nao Existe", "Metodo BackupDatabaseCopyDB()");
                            }

                            break;
                        }
                    case (false):
                        {
                            if (System.IO.File.Exists(myDataSource))
                            {
                                var DestfileName = (String.Format(("{0}{1}{2}{3}"), (backupFolderDefault), ("Backup_"), (dt.ToString("DATE_dd_MM_yyyy_T_HH_mm_ss_fff_")), (fileName)));
                                System.IO.File.Copy((myDataSource), (DestfileName));
                                myReturn = (String.Format(("{0}"), ("OK")));
                            }
                            else
                            {
                                throw new System.ArgumentException("Erro Arquivo nao Existe", "Metodo BackupDatabaseCopyDB()");
                            }
                            break;
                        }
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
