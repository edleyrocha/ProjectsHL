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
        /// #H Metodo para BackupDB via Copy
        /// </summary>
        /// <param name="myDataSource"> Patch Source</param>
        /// <param name="myMoveBD">Move or NOT Move</param>
        /// <returns>Retorna string </returns>
        public static string BackupCopyDB(String myDataSource, Boolean myMoveBD)
        {
            //String Retorno Padrao
            var myReturn = (String.Empty);
            try
            {
                // Check File (myDataSource) EXIST
                if (!System.IO.File.Exists(myDataSource))
                {
                    /// Check File (myDataSource) NOT EXIST - ERRO
                    throw new System.ArgumentException("Erro File Source Nao Existe (00001)", "Metodo BackupCopyDB()");
                }

                //SET Pasta Default para BackupDB
                var BackupDB_Folder = (System.IO.Path.GetDirectoryName(myDataSource));
                BackupDB_Folder = (System.IO.Path.Combine((BackupDB_Folder), (@"BackupDB\")));

                // Criar Diretorio
                System.IO.Directory.CreateDirectory(BackupDB_Folder);

                // Check DirectoryName (\BackupDB) EXIST
                if (!System.IO.Directory.Exists(BackupDB_Folder))
                {
                    // Check DirectoryName (\BackupDB) NOT EXIST - ERRO
                    throw new System.ArgumentException("Erro ao Criar pasta BackupDB (00002)", "Metodo BackupCopyDB()");
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
                    throw new System.ArgumentException("Erro BACKUP nao Encontrado (00003)", "Metodo BackupCopyDB()");
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
        /// <summary>
        /// #H Metodo para Criar Banco de Dados (Melhor Metodo)
        /// </summary>
        /// <param name="Parametros"> SQLiteConnectionStringBuilder como Parametro</param>
        /// <returns>Retorna string</returns>
        public static string CreateFileDB(H_SQLiteConnectionStringBuilder Parametros)
        {
            //Default Return
            var myReturn = (String.Empty);
            try
            {
                // File Patch via Parametros
                var FilePatch = (Parametros.GetStringBuilder.DataSource);
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
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(Parametros.GetStringBuilder.ConnectionString)))
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
        /// <param name="Parametros">Parametros H_SQLiteConnectionStringBuilder </param>
        /// <param name="ParametroSQL">Parametros StringBuilder </param>
        /// <returns></returns>
        public static string SQLExecuteNonQuery(H_SQLiteConnectionStringBuilder Parametros, System.Text.StringBuilder ParametroSQL)
        {
            //Default Return
            var myReturn = (String.Empty);
            try
            {
                // File Patch via Parametros
                var FilePatch = (Parametros.GetStringBuilder.DataSource);
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
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(Parametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = new System.Data.SQLite.SQLiteCommand(SQLiteConn))
                    {
                        cmdSQL.CommandType = (System.Data.CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (ParametroSQL.ToString());
                        var count_I = (0);
                        SQLiteConn.Open();

                        count_I = (cmdSQL.ExecuteNonQuery());

                        if (count_I <= (-1))
                        {
                            // Check Exec SQL - ERRO
                            throw new System.ArgumentException("Erro Exec SQL (00003) Erro", "Metodo SQLExecuteNonQuery()");
                        }

                        SQLiteConn.Close();
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
        /// #H Metodo ExecuteSQL_ReturnDataset()
        /// </summary>
        /// <param name="Parametros">Parametros de Conexao</param>
        /// <param name="ParametroSQL"> Parametros SQL</param>
        /// <param name="ParametroSaida"> Parametro de Saida </param>
        /// <returns></returns>
        public static System.Data.DataSet ExecuteSQL_ReturnDataset(H_SQLiteConnectionStringBuilder Parametros, System.Text.StringBuilder ParametroSQL, ref string ParametroSaida)
        {
            //Default Return
            var myReturn = (new System.Data.DataSet());
            try
            {
                // File Patch via Parametros
                var FilePatch = (Parametros.GetStringBuilder.DataSource);
                // Check DirectoryName Exists
                var DirectoryName = (System.IO.Path.GetDirectoryName(FilePatch));
                if (!System.IO.Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new System.ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo ExecuteSQL_ReturnDataset()");
                };
                // Check File NOT Exists 
                if (!System.IO.File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new System.ArgumentException("Erro File Name (00002) NOT Exists", "Metodo ExecuteSQL_ReturnDataset()");
                };
                // Abrir Banco de Dados
                using (var SQLiteConn = (new System.Data.SQLite.SQLiteConnection(Parametros.GetStringBuilder.ConnectionString)))
                {
                    using (var cmdSQL = new System.Data.SQLite.SQLiteCommand(SQLiteConn))
                    {
                        cmdSQL.CommandType = (System.Data.CommandType.Text);
                        cmdSQL.CommandTimeout = (3);
                        cmdSQL.CommandText = (ParametroSQL.ToString());
                        using (var adapterSQL = new System.Data.SQLite.SQLiteDataAdapter(cmdSQL))
                        {
                            SQLiteConn.Open();
                            var count_I = (0);
                            count_I = adapterSQL.Fill(myReturn);
                            if (count_I <= (-1))
                            {
                                // Check Exec SQL - ERRO
                                throw new System.ArgumentException("Erro Exec SQL (00003) Erro", "Metodo ExecuteSQL_ReturnDataset()");
                            };
                            SQLiteConn.Close();
                        };
                    };
                };
                // Returno de Sucesso
                // myReturn = (String.Format(("{0}"), ("OK")));
            }
            catch (Exception myEx)
            {
                //Retorno de Erro
                ParametroSaida = (String.Format(("Erro:\n{0}"), (myEx.ToString())));
            }
            //Retorno do metodo
            return (myReturn);
        }
        /// <summary>
        /// #H Metodo para Criar Default Banco de Dados e Armazenar as Configuraçoes
        /// </summary>
        public static void CreateFileDB_Default()
        {
            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var PasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes("balada"));


            H_SQLiteConnectionStringBuilder Parametros = new H_SQLiteConnectionStringBuilder()
            {
                @StringBuilder_1_SetDataSource = (FileNameComExtencao),
                @StringBuilder_3_SetPassword = ("balada"),
                @StringBuilder_4_SetFailIfMissing = (false)
            };
            HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDB(Parametros: Parametros);
        }
        /// <summary>
        /// #H Metodo SQLExecuteNonQuery_Default() Roda Somente no Banco Default
        /// </summary>
        /// <param name="ParametroSQL">Parametro StringBuilder</param>
        public static void SQLExecuteNonQuery_Default(System.Text.StringBuilder ParametroSQL)
        {
            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var PasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes("balada"));


            H_SQLiteConnectionStringBuilder Parametros = new H_SQLiteConnectionStringBuilder()
            {
                @StringBuilder_1_SetDataSource = (FileNameComExtencao),
                @StringBuilder_3_SetPassword = ("balada")
            };
            var msg = (System.String.Empty);
            HOYLER.Data.SQLite.H_SQLiteDatabase.SQLExecuteNonQuery(
                                                          Parametros: Parametros,
                                                          ParametroSQL: ParametroSQL
                                                          );
            System.Windows.Forms.MessageBox.Show(msg);
        }
        ///// <summary>
        ///// #H Metodo ExecuteSQL_ReturnDataset_Default
        ///// </summary>
        ///// <param name="ParametroSQL">Parametro StringBuilder</param>
        //public static void ExecuteSQL_ReturnDataset_Default(System.Text.StringBuilder ParametroSQL)
        //{
 
        //    var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
        //    var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        //    var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
        //    var Extencao = (".db3");
        //    var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
        //    var PasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes("balada"));
        //    H_SQLiteConnectionStringBuilder Parametros = new H_SQLiteConnectionStringBuilder()
        //    {
        //        @StringBuilder_1_SetDataSource = (FileNameComExtencao),
        //        @StringBuilder_3_SetPassword = ("balada")
        //    };
        //    var ParametroSaida = (String.Empty);
        //    var ds = HOYLER.Data.SQLite.H_SQLiteDatabase.ExecuteSQL_ReturnDataset
        //    (
        //    @Parametros: Parametros,
        //    @ParametroSQL: ParametroSQL,
        //    ParametroSaida: ref ParametroSaida
        //    );
            



        //}
    }
}
