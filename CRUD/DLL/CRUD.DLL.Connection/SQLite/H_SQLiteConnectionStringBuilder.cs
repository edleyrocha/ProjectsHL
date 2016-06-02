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
    /// #H Classe H_SQLiteConnectionStringBuilder
    /// </summary>
    class H_SQLiteConnectionStringBuilder
    {
        /// <summary>
        /// #H Metodo Construtor H_SQLiteConnectionStringBuilder
        /// </summary>
        public H_SQLiteConnectionStringBuilder()
        {
            this.H_ConfigureDefault();
        }
        /// <summary>
        /// #H Metodo H_ConfigureDefault()
        /// </summary>
        private void H_ConfigureDefault()
        {
            _stringBuilder.Clear();
            _stringBuilder.SetDefaults = (true);
            _stringBuilder.FailIfMissing = (true);
            _stringBuilder.ForeignKeys = (true); // Segurança por Padrao Nao Pemite Criar 
            _stringBuilder.DefaultTimeout = (5000);
            _stringBuilder.PageSize = (65536);
            _stringBuilder.CacheSize = (2048000);
            _stringBuilder.SyncMode = (System.Data.SQLite.SynchronizationModes.Full);
            _stringBuilder.JournalMode = (System.Data.SQLite.SQLiteJournalModeEnum.Memory);
            _stringBuilder.Flags = (System.Data.SQLite.SQLiteConnectionFlags.LogAll);
        }
        /// <summary>
        /// #H _stringBuilder SQLiteConnectionStringBuilder
        /// </summary>
        private SQLiteConnectionStringBuilder _stringBuilder = new SQLiteConnectionStringBuilder();
        public SQLiteConnectionStringBuilder GetStringBuilder
        {
            get { return _stringBuilder; }
            //set { _stringBuilder = value; }
        }
        public string StringBuilder_1_SetDataSource
        {
            //get { return StringBuilder.DataSource; }
            set { _stringBuilder.DataSource = value; }
        }
        public byte[] StringBuilder_2_SetHexPassword
        {
            //get { return StringBuilder.HexPassword; }
            set { _stringBuilder.HexPassword = value; }
        }
        public bool StringBuilder_3_SetFailIfMissing
        {
            //get { return StringBuilder.FailIfMissing; }
            set { _stringBuilder.FailIfMissing = value; }
        }
    }
}
