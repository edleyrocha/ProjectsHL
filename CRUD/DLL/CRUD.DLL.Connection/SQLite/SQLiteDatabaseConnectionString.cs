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
    /// #H Classe H_SQLiteDatabaseConnectionString
    /// </summary>
    public static class H_SQLiteDatabaseConnectionString
    {
        /// <summary>
        /// #H String for SQLiteConnection
        /// </summary>
        private static SQLiteConnectionStringBuilder _SQLiteString = (new SQLiteConnectionStringBuilder());
        /// <summary>
        /// #H Metodo Configure Default SQLite ConnectionString
        /// </summary>
        private static void _ConfigureDefaultSQLiteString()
        {
            _SQLiteString.Clear();
            _SQLiteString.DefaultTimeout = (5000);
            _SQLiteString.PageSize = (65536);
            _SQLiteString.CacheSize = (2048000);
            _SQLiteString.FailIfMissing = (false);
            _SQLiteString.SyncMode = (SynchronizationModes.Full);
            _SQLiteString.JournalMode = (SQLiteJournalModeEnum.Memory);
            _SQLiteString.ForeignKeys = (true);
            _SQLiteString.Flags = (SQLiteConnectionFlags.LogAll);
        }
        /// <summary>
        /// #H Metodo Retona String Completa para SQLite
        /// </summary>
        /// <param name="myDataSource">Patch Database</param>
        /// <param name="myHexPassword">Hex Password</param>
        /// <returns>Retona SQLiteConnectionStringBuilder</returns>
        public static SQLiteConnectionStringBuilder GetConnectionString(String myDataSource, byte[] myHexPassword)
        {
            // Set Default Config
           _ConfigureDefaultSQLiteString();
           _SQLiteString.DataSource = (myDataSource);
           _SQLiteString.HexPassword = (myHexPassword);
           return (_SQLiteString);
        }
    }
}
