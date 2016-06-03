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
        /// #H Metodo ConfigureDefault()
        /// </summary>
        private void ConfigureDefault()
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
        /// #H Field _stringBuilder SQLiteConnectionStringBuilder
        /// </summary>
        private System.Data.SQLite.SQLiteConnectionStringBuilder _stringBuilder = new System.Data.SQLite.SQLiteConnectionStringBuilder();
        /// <summary>
        /// # Metodo Retorno _stringBuilder
        /// </summary>
        public System.Data.SQLite.SQLiteConnectionStringBuilder GetStringBuilder
        {
            get { return _stringBuilder; }
        }
        /// <summary>
        /// # Metodo Set DataSource
        /// </summary>
        public string StringBuilder_1_SetDataSource
        {
            set { _stringBuilder.DataSource = value; }
        }
        /// <summary>
        /// # Metodo Set HexPassword
        /// </summary>
        public byte[] StringBuilder_2_SetHexPassword
        {
            set { _stringBuilder.HexPassword = value; }
        }
        /// <summary>
        /// # Metodo Set Password
        /// </summary>
        public string StringBuilder_3_SetPassword
        {
            set { _stringBuilder.Password = value; }
        }
        /// <summary>
        /// # Metodo Set FailIfMissing
        /// </summary>
        public bool StringBuilder_4_SetFailIfMissing
        {
            set { _stringBuilder.FailIfMissing = value; }
        }
    }
}
