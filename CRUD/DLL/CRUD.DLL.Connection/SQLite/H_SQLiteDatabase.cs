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
        /// <param name="myParametros">SQLiteConnectionStringBuilder como Parametro</param>
        /// <returns>Retorna string</returns>
        public static string CreateFileDB(H_SQLiteConnectionStringBuilder myParametros)
        {
            //Default Return
            var myReturn = (String.Empty);
            try
            {
                // File Patch via myParametro
                var FilePatch = (@myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (System.IO.Path.GetDirectoryName(FilePatch));
                if (!System.IO.Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new System.ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo CreateFileDB()");
                };
                // Check File Exists 
                if (System.IO.File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00002) Exists", "Metodo CreateFileDB()");
                };
                // Cria Banco de Dados
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(@myParametros.GetStringBuilder.ConnectionString)))
                {
                    // Testa se abre e Fecha
                    SQLiteConn.Open();
                    SQLiteConn.Close();
                };

                // Check File NOT Exists 
                if (!System.IO.File.Exists(FilePatch))
                {
                    // Check File NOT Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00003) NOT Exists", "Metodo CreateFileDB()");
                };
                // Returno de Sucesso
                myReturn = (String.Format(("{0}"), ("OK")));
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo SQLExecuteNonQuery()
        /// </summary>
        /// <param name="myParametro">myParametro H_SQLiteConnectionStringBuilder </param>
        /// <param name="myParametroSQL">myParametro StringBuilder </param>
        /// <returns>Return Status</returns>
        public static string SQLExecuteNonQuery(H_SQLiteConnectionStringBuilder myParametros, String myParametroSQL)
        {
            //Default Return
            var myReturn = (String.Empty);
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (System.IO.Path.GetDirectoryName(FilePatch));
                if (!System.IO.Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new System.ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo SQLExecuteNonQuery()");
                };
                // Check File NOT Exists 
                if (!System.IO.File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00002) NOT Exists", "Metodo SQLExecuteNonQuery()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = new System.Data.SQLite.SQLiteCommand(SQLiteConn))
                    {
                        cmdSQL.CommandType = (System.Data.CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (myParametroSQL);
                        var count_I = (-666);
                        SQLiteConn.Open();
                        using (SQLiteTransaction sqliteTransaction = SQLiteConn.BeginTransaction())
                        {
                            count_I = (cmdSQL.ExecuteNonQuery());
                            sqliteTransaction.Commit();
                        };
                        if (count_I <= (-1))
                        {
                            // Check Exec SQL - ERRO
                            throw new System.ArgumentException("Erro Exec SQL (00003) Erro", "Metodo SQLExecuteNonQuery()");
                        }
                    }
                };
                // Returno de Sucesso
                myReturn = (String.Format(("{0}"), ("OK")));
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                myReturn = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo ExecuteSQLReturnDataset()
        /// </summary>
        /// <param name="myParametros">Conexao</param>
        /// <param name="myParametroSQL">SQL</param>
        /// <param name="myParametroSaida">Saida </param>
        /// <returns>>Retorna Data Table</returns>
        public static System.Data.DataSet ExecuteSQLReturnDataset(H_SQLiteConnectionStringBuilder myParametros, String myParametroSQL, ref String myParametroSaida)
        {
            //Default Return
            var myReturn = (new System.Data.DataSet());
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (System.IO.Path.GetDirectoryName(FilePatch));
                if (!System.IO.Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new System.ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo ExecuteSQLReturnDataset()");
                };
                // Check File NOT Exists 
                if (!System.IO.File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00002) NOT Exists", "Metodo ExecuteSQLReturnDataset()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = new System.Data.SQLite.SQLiteCommand(SQLiteConn))
                    {
                        cmdSQL.CommandType = (System.Data.CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (myParametroSQL);
                        using (var adapterSQL = new System.Data.SQLite.SQLiteDataAdapter(cmdSQL))
                        {
                            SQLiteConn.Open();
                            var count_I = (0);
                            count_I = adapterSQL.Fill(myReturn);
                            if (count_I <= (-1))
                            {
                                // Check Exec SQL - ERRO
                                throw new System.ArgumentException("Erro Exec SQL (00003) Erro", "Metodo ExecuteSQLReturnDataset()");
                            };
                            SQLiteConn.Close();
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
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo ExecuteSQLReturnDataTable()
        /// </summary>
        /// <param name="myParametros">Conexao</param>
        /// <param name="myParametroSQL">SQL</param>
        /// <param name="myParametroSaida">Saida </param>
        /// <returns>Retorna Data Table</returns>
        public static System.Data.DataTable ExecuteSQLReturnDataTable(H_SQLiteConnectionStringBuilder myParametros, System.Text.StringBuilder myParametroSQL, ref string myParametroSaida)
        {
            //Default Return
            var myReturn = (new System.Data.DataTable());
            try
            {
                // File Patch via myParametro
                var FilePatch = (myParametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (System.IO.Path.GetDirectoryName(FilePatch));
                if (!System.IO.Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new System.ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo ExecuteSQLReturnDataTable()");
                };
                // Check File NOT Exists 
                if (!System.IO.File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00002) NOT Exists", "Metodo ExecuteSQLReturnDataTable()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(myParametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = new System.Data.SQLite.SQLiteCommand(SQLiteConn))
                    {
                        cmdSQL.CommandType = (System.Data.CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (myParametroSQL.ToString());
                        using (var adapterSQL = new System.Data.SQLite.SQLiteDataAdapter(cmdSQL))
                        {
                            SQLiteConn.Open();
                            var count_I = (0);
                            count_I = adapterSQL.Fill(myReturn);
                            if (count_I <= (-1))
                            {
                                // Check Exec SQL - ERRO
                                throw new System.ArgumentException("Erro Exec SQL (00003) Erro", "Metodo ExecuteSQLReturnDataTable()");
                            };
                            SQLiteConn.Close();
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
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo CreateFileDBDefault - Criar Default Banco de Dados e Armazenar as Configuraçoes
        /// </summary>
        /// <returns>Retorna Status</returns>
        public static string CreateFileDBDefault()
        {
            //Default Return
            var myReturn = (String.Empty);

            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");

            H_SQLiteConnectionStringBuilder Parametros = new H_SQLiteConnectionStringBuilder()
            {
                SetStringBuilder1_DataSource = (FileNameComExtencao),
                SetStringBuilder2_Password = (Passwd),
                SetStringBuilder3_FailIfMissing = (false) //CREATE IF NOT EXIST
            };

            myReturn = (HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDB(myParametros: Parametros));
            //Retorno do metodo
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo SQLExecuteNonQueryDefault() - Roda Somente no Banco Default
        /// </summary>
        /// <param name="myParametroSQL">String como Parametros</param>
        /// <returns>Retorna Status</returns>
        public static string SQLExecuteNonQueryDefault(String myParametroSQL)
        {
            //Default Return
            var myReturn = (String.Empty);
            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            H_SQLiteConnectionStringBuilder myParametros = new H_SQLiteConnectionStringBuilder()
            {
                @SetStringBuilder1_DataSource = (FileNameComExtencao),
                @SetStringBuilder2_Password = (Passwd),
            };
            myReturn = (HOYLER.Data.SQLite.H_SQLiteDatabase.SQLExecuteNonQuery(
                                                                               @myParametros: myParametros,
                                                                               @myParametroSQL: myParametroSQL
                                                                               ));
            //Retorno do metodo
            return (myReturn);
        }
    }
}
