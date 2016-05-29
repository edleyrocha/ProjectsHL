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
    /// # Classe SQLiteDatabaseCreate
    /// </summary>
    public class SQLiteDatabaseCreate
    {
        /// <summary>
        /// # Metodo Contrutor SQLiteDatabaseCreate()
        /// </summary>
        public SQLiteDatabaseCreate()
        {
            this.ConfigureDefaultSQLiteString();
        }
        /// <summary>
        /// # String for SQLiteConnection
        /// </summary>
        private System.Data.SQLite.SQLiteConnectionStringBuilder SQLiteString = (new System.Data.SQLite.SQLiteConnectionStringBuilder());
        /// <summary>
        /// # Metodo Configure Default SQLite ConnectionString
        /// </summary>
        private void ConfigureDefaultSQLiteString()
        {
            SQLiteString.Clear();
            SQLiteString.DefaultTimeout = (5000);
            SQLiteString.PageSize = (65536);
            SQLiteString.CacheSize = (2048000);
            SQLiteString.FailIfMissing = (false);
            SQLiteString.SyncMode = (System.Data.SQLite.SynchronizationModes.Full);
            SQLiteString.JournalMode = (System.Data.SQLite.SQLiteJournalModeEnum.Memory);
            SQLiteString.ForeignKeys = (true);
            SQLiteString.Flags = (System.Data.SQLite.SQLiteConnectionFlags.LogAll);
        }
        /// <summary>
        /// # Metodo para Criar Banco de Dados
        /// </summary>
        /// <param name="myDataSource">Caminho e Name para Banco de Dados</param>
        /// <param name="myHexPassword">Senha para Banco de dados</param>
        /// <returns></returns>
        public String DatabaseCreateFile(String myDataSource, byte[] myHexPassword)
        {
            var myReturn = (String.Empty);
            var myDatabaseExists = (System.IO.File.Exists(myDataSource));
            if (!myDatabaseExists)
            {
                try
                {
                    SQLiteString.DataSource = (myDataSource);
                    SQLiteString.HexPassword = (myHexPassword);
                    using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(SQLiteString.ConnectionString)))
                    {
                        SQLiteConn.Open();
                        myReturn = ("Sucesso:\n");
                        myReturn += ("Banco de Dados Criado");
                    }
                }
                catch (Exception myEx)
                {
                    myReturn = ("Erro:\n");
                    myReturn += (myEx.ToString());
                }
            }
            else if (myDatabaseExists)
            {
                myReturn = ("Erro:\n");
                myReturn += ("Banco de Dados já Existe");
            }
            return (myReturn);
        }
    }
}
