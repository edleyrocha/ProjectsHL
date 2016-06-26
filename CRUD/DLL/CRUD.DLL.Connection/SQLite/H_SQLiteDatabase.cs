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
using System.Data;
using System.Data.SQLite;
namespace HOYLER.Data.SQLite
{
    /// <summary>
    /// #H Classe H_SQLiteDatabase
    /// </summary>
    public class H_SQLiteDatabase
    {
        /// <summary>
        /// #H Metodo Construtor H_SQLiteDatabase()
        /// </summary>
        public H_SQLiteDatabase()
        {
        }
        /// <summary>
        /// #H Metodo CreateFileDB() - Criar Banco de Dados (Melhor Montodo)
        /// </summary>
        /// <param name="Parametros">SQLiteConnectionStringBuilder como Parametro</param>
        /// <returns>Retorna string</returns>
        public static String CreateFileDB(H_SQLiteConnectionStringBuilder myParametros)
        {
            //Default Retorno
            var myReturn_String = (String.Empty);
            try
            {
                // File Patch via myParametros
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(FilePatch));
                if (!Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo CreateFileDB()");
                };
                // Check File Exists 
                if (File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new ArgumentException("Erro File Name (00002) Exists", "Metodo CreateFileDB()");
                };
                // Cria Banco de Dados
                using (var SQLiteConn = (new SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    // Testa se abre e Fecha
                    SQLiteConn.Open();
                    SQLiteConn.Close();
                };
                // Check File NOT Exists 
                if (!File.Exists(FilePatch))
                {
                    // Check File NOT Exists - ERRO
                    throw new ArgumentException("Erro File Name (00003) NOT Exists", "Metodo CreateFileDB()");
                };
                // Returno de Sucesso
                myReturn_String = (String.Format(("{0}"), ("OK")));
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myReturn_String = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn_String);
        }
        /// <summary>
        /// #H Metodo SQLExecuteNonQuery()
        /// </summary>
        /// <param name="myParametro">myParametro H_SQLiteConnectionStringBuilder </param>
        /// <param name="myParametroSQL">myParametro StringBuilder </param>
        /// <returns>Return Status</returns>
        public static String SQLExecuteNonQuery(H_SQLiteConnectionStringBuilder myParametros, String myParametroSQL)
        {
            //Default Return
            var myReturn_String = (String.Empty);
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(FilePatch));
                if (!Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo SQLExecuteNonQuery()");
                };
                // Check File NOT Exists 
                if (!File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new ArgumentException("Erro File Name (00002) NOT Exists", "Metodo SQLExecuteNonQuery()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var SQLcmd = (new SQLiteCommand(SQLiteConn)))
                    {
                        SQLcmd.CommandType = (CommandType.Text);
                        SQLcmd.CommandTimeout = (5);
                        SQLcmd.CommandText = (myParametroSQL);
                        var count_I = (0);
                        SQLiteConn.Open();
                        using (var SQLiteTransactionBegin = (SQLiteConn.BeginTransaction()))
                        {
                            count_I = (SQLcmd.ExecuteNonQuery());
                            SQLiteTransactionBegin.Commit();
                        };
                        if (count_I == (-1))
                        {
                            // Check Exec SQL - ERRO
                            throw new ArgumentException("Erro Exec SQL (00003) Erro", "Metodo SQLExecuteNonQuery()");
                        };
                        // Returno de Sucesso
                        myReturn_String = (String.Format(("{0}"), ("OK")));
                    };
                };
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myReturn_String = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn_String);
        }
        /// <summary>
        /// #H Metodo ExecuteSQLReturnDataset()
        /// </summary>
        /// <param name="Parametros">Conexao</param>
        /// <param name="myParametroSQL">SQL</param>
        /// <param name="myParametroSaida">Saida </param>
        /// <returns>>Retorna DataSet</returns>
        public static DataSet ExecuteSQLReturnDataset(H_SQLiteConnectionStringBuilder myParametros, String myParametroSQL, ref String myParametroSaida)
        {
            //Default Return
            var myReturn_DataSet = (new DataSet());
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(FilePatch));
                if (!Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo ExecuteSQLReturnDataset()");
                };
                // Check File NOT Exists 
                if (!File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new ArgumentException("Erro File Name (00002) NOT Exists", "Metodo ExecuteSQLReturnDataset()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = (new SQLiteCommand(SQLiteConn)))
                    {
                        cmdSQL.CommandType = (CommandType.Text);
                        cmdSQL.CommandTimeout = (5);
                        cmdSQL.CommandText = (myParametroSQL);
                        using (var adapterSQL = (new SQLiteDataAdapter(cmdSQL)))
                        {
                            SQLiteConn.Open();
                            using (var SQLiteTransactionBegin = SQLiteConn.BeginTransaction())
                            {
                                var count_I = (0);
                                count_I = adapterSQL.Fill(myReturn_DataSet);
                                SQLiteTransactionBegin.Commit();
                                if (count_I == (-1))
                                {
                                    // Check Exec SQL - ERRO
                                    throw new ArgumentException("Erro Exec SQL (00003) Erro", "Metodo ExecuteSQLReturnDataset()");
                                };
                                myParametroSaida = (String.Format(("{0}"), ("OK")));
                            };
                        };
                    };
                };
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myParametroSaida = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn_DataSet);
        }
        /// <summary>
        /// #H Metodo ExecuteSQLReturnDataTable()
        /// </summary>
        /// <param name="Parametros">Conexao</param>
        /// <param name="myParametroSQL">SQL</param>
        /// <param name="myParametroSaida">Saida </param>
        /// <returns>Retorna Data Table</returns>
        public static DataTable ExecuteSQLReturnDataTable(H_SQLiteConnectionStringBuilder myParametros, String myParametroSQL, ref String myParametroSaida)
        {
            //Default Return
            var myReturn_DataTable = (new DataTable());
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(FilePatch));
                if (!Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo ExecuteSQLReturnDataTable()");
                };
                // Check File NOT Exists 
                if (!File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new ArgumentException("Erro File Name (00002) NOT Exists", "Metodo ExecuteSQLReturnDataTable()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = (new SQLiteCommand(SQLiteConn)))
                    {
                        cmdSQL.CommandType = (CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (myParametroSQL.ToString());
                        using (var adapterSQL = (new SQLiteDataAdapter(cmdSQL)))
                        {
                            SQLiteConn.Open();
                            using (var SQLiteTransactionBegin = SQLiteConn.BeginTransaction())
                            {
                                var count_I = (0);
                                count_I = adapterSQL.Fill(myReturn_DataTable);
                                SQLiteTransactionBegin.Commit();
                                if (count_I == (-1))
                                {
                                    // Check Exec SQL - ERRO
                                    throw new ArgumentException("Erro Exec SQL (00003) Erro", "Metodo ExecuteSQLReturnDataTable()");
                                };
                                myParametroSaida = (String.Format(("{0}"), ("OK")));
                            };
                        };
                    };
                };
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myParametroSaida = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn_DataTable);
        }
    }
}
