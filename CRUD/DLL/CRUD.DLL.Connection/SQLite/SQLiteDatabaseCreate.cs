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
using System.Data.SQLite;
namespace HOYLER.Data.SQLite
{
    /// <summary>
    /// # Classe SQLiteDatabaseCreate
    /// </summary>
    public class SQLiteDatabaseCreate
    {
        /// <summary>
        /// # Metodo Contrutor da Classe SQLiteDatabaseCreate()
        /// </summary>
        public SQLiteDatabaseCreate()
        {
        }
        /// <summary>
        /// # String for SQLiteConnection
        /// </summary>
        private static SQLiteConnectionStringBuilder _SQLiteString = (new SQLiteConnectionStringBuilder());
        /// <summary>
        /// # Metodo Configure Default SQLite ConnectionString
        /// </summary>
        private static void _ConfigureDefaultSQLiteString()
        {
            _SQLiteString.Clear();
            _SQLiteString.DefaultTimeout = (5000);
            _SQLiteString.PageSize = (65536);
            _SQLiteString.CacheSize = (2048000);
            _SQLiteString.FailIfMissing = (false);
            _SQLiteString.SyncMode = (System.Data.SQLite.SynchronizationModes.Full);
            _SQLiteString.JournalMode = (System.Data.SQLite.SQLiteJournalModeEnum.Memory);
            _SQLiteString.ForeignKeys = (true);
            _SQLiteString.Flags = (System.Data.SQLite.SQLiteConnectionFlags.LogAll);
        }
        /// <summary>
        /// # Metodo para Criar Banco de Dados
        /// </summary>
        /// <param name="myDataSource">Caminho e Name para Banco de Dados</param>
        /// <param name="myHexPassword">Senha para Banco de dados</param>
        /// <returns>Retorna string</returns>
        public static string DatabaseCreateFile(String myDataSource, byte[] myHexPassword)
        {
            var myReturn = (String.Empty);

            //Check if Diretory Exists
            var myDatabaseDiretoryExist = (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(myDataSource)));
            if (myDatabaseDiretoryExist)
            {
                //Check if File Exists 
                var myDatabaseFileExist = (System.IO.File.Exists(myDataSource));
                if (!myDatabaseFileExist)
                {
                    try
                    {
                        // Default Configure Strings 
                        _ConfigureDefaultSQLiteString();

                        // Set Patch for Strings
                        _SQLiteString.DataSource = (myDataSource);

                        // Set Password if Exist
                        _SQLiteString.HexPassword = (myHexPassword);
                        // Criar Banco de Dados (Abrir e Fechar)
                        using (var SQLiteConn = (new SQLiteConnection(_SQLiteString.ConnectionString)))
                        {
                            SQLiteConn.Open();
                            SQLiteConn.Close();
                        };
                        myReturn = (String.Format(("{0}"), ("OK")));
                    }
                    catch (Exception myEx)
                    {
                        myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
                    }
                }
                else if (myDatabaseFileExist)
                {
                    myReturn = (String.Format(("Erro:\n{0}"), ("Banco de Dados já Existe")));
                };
            }
            else if (!myDatabaseDiretoryExist)
            {
                myReturn = (String.Format(("Erro:\n{0}"), ("Diretorio não Existe")));
            };
            return (myReturn);
        }
        /// <summary>
        /// # Metodo para Criar Banco de Dados
        /// </summary>
        /// <param name="myStringBuilder"> SQLiteConnectionStringBuilder como Parametro</param>
        /// <returns>Retorna string</returns>
        public static string DatabaseCreateFile(SQLiteConnectionStringBuilder myStringBuilder)
        {
            var myReturn = (String.Empty);

            //var myDatabasePatch = (System.IO.Path.GetDirectoryName(myStringBuilder.DataSource));
            //var myDatabaseFile = (System.IO.Path.GetFileName(myStringBuilder.DataSource));

            //Check if Diretory Exists
            var myDatabaseDiretoryExist = (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(myStringBuilder.DataSource)));

            //Check if Diretory Exists
            if (myDatabaseDiretoryExist)
            {
                // Check if File Exists
                var myDatabaseExists = (System.IO.File.Exists(myStringBuilder.DataSource));
                if (!myDatabaseExists)
                {
                    try
                    {
                        using (var SQLiteConn = (new SQLiteConnection(myStringBuilder.ConnectionString)))
                        {
                            SQLiteConn.Open();
                            SQLiteConn.Close();
                        };
                        myReturn = (String.Format(("{0}"), ("OK")));
                    }
                    catch (Exception myEx)
                    {
                        myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
                    }
                }
                else if (myDatabaseExists)
                {
                    myReturn = (String.Format(("Erro:\n{0}"), ("Banco de Dados já Existe")));
                }
            }
            else if (!myDatabaseDiretoryExist)
            {
                myReturn = (String.Format(("Erro:\n{0}"), ("Diretorio não Existe")));
            };
            return (myReturn);
        }
    }
}
