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
    public class H_SQLiteConnectionStringBuilder
    {
        /// <summary>
        /// #H Metodo Construtor H_SQLiteConnectionStringBuilder()
        /// </summary>
        public H_SQLiteConnectionStringBuilder()
        {
            /// <summary>
            /// #H Executa Metodo ConfigureDefault();
            /// </summary>
            this.ConfigureDefault();
        }
        /// <summary>
        /// #H Field _SQLiteConnStringBuilder SQLiteConnectionStringBuilder
        /// </summary>
        private SQLiteConnectionStringBuilder _SQLiteConnStringBuilder = new SQLiteConnectionStringBuilder();
        /// <summary>
        /// #H Metodo ConfigureDefault()
        /// </summary>
        private void ConfigureDefault()
        {
            _SQLiteConnStringBuilder.Clear();
            _SQLiteConnStringBuilder.SetDefaults = (true);
            _SQLiteConnStringBuilder.FailIfMissing = (true); // Segurança por Padrao Nao Pemite Criar novo DB
            _SQLiteConnStringBuilder.ForeignKeys = (true); 
            _SQLiteConnStringBuilder.DefaultTimeout = (5000);
            _SQLiteConnStringBuilder.PageSize = (65536);
            _SQLiteConnStringBuilder.CacheSize = (2048000);
            _SQLiteConnStringBuilder.SyncMode = (System.Data.SQLite.SynchronizationModes.Full);
            _SQLiteConnStringBuilder.JournalMode = (System.Data.SQLite.SQLiteJournalModeEnum.Memory);
            _SQLiteConnStringBuilder.Flags = (System.Data.SQLite.SQLiteConnectionFlags.LogAll);
        }
        /// <summary>
        /// #H Metodo Retorno _SQLiteConnStringBuilder
        /// </summary>
        public SQLiteConnectionStringBuilder GetStringBuilder
        {
            get { return _SQLiteConnStringBuilder; }
        }
        /// <summary>
        /// #H Metodo Set DataSource
        /// </summary>
        public string SetStringBuilder1_DataSource
        {
            set { _SQLiteConnStringBuilder.DataSource = value; }
        }
        /// <summary>
        /// #H Metodo Set HexPassword
        /// </summary>
        public byte[] SetStringBuilder2_HexPassword
        {
            set { _SQLiteConnStringBuilder.HexPassword = value; }
        }
        /// <summary>
        /// #H Metodo Set Password
        /// </summary>
        public string SetStringBuilder2_Password
        {
            set { _SQLiteConnStringBuilder.Password = value; }
        }
        /// <summary>
        /// #H Metodo Set FailIfMissing
        /// </summary>
        public bool SetStringBuilder3_FailIfMissing
        {
            set { _SQLiteConnStringBuilder.FailIfMissing = value; }
        }
        /// <summary>
        /// #H Metodo Set ReadOnly
        /// </summary>
        public bool SetStringBuilder4_ReadOnly
        {
            set { _SQLiteConnStringBuilder.ReadOnly = value; }
        }
    }
}
