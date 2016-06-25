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
using System.Diagnostics;
namespace HOYLER.Data.SQLite
{
    /// <summary>
    /// #H Classe H_SQLiteDatabaseDefault
    /// </summary>
    public class H_SQLiteDatabaseDefault
    {
        /// <summary>
        /// #H Metodo Contrutor H_SQLiteDatabaseDefault()
        /// </summary>
        public H_SQLiteDatabaseDefault()
        {
        }
        /// <summary>
        /// #H Metodo CreateFileDBDefault - Criar Default Banco de Dados e Armazenar as Configuraçoes
        /// </summary>
        /// <returns>Retorna Status</returns>
        public static String CreateFileDBDefault()
        {
            //Default Return
            var myReturn_String = (String.Empty);
            var DirectoryName = (Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            H_SQLiteConnectionStringBuilder Parametros = (new H_SQLiteConnectionStringBuilder()
            {
                SetStringBuilder1_DataSource = (FileNameComExtencao),
                SetStringBuilder2_Password = (Passwd),
                SetStringBuilder3_FailIfMissing = (false) //CREATE IF NOT EXIST
            });
            //Default Return
            myReturn_String = (H_SQLiteDatabase.CreateFileDB(myParametros: Parametros));
            //Retorno do metodo
            return (myReturn_String);
        }
        /// <summary>
        /// #H Metodo SQLExecuteNonQueryDefault() - Roda Somente no Banco Default
        /// </summary>
        /// <param name="myParametroSQL">String como Parametros</param>
        /// <returns>Retorna Status</returns>
        public static String SQLExecuteNonQueryDefault(String myParametroSQL)
        {
            //Default Return
            var myReturn_String = (String.Empty);
            myParametroSQL = (myParametroSQL.Replace("\t", "").Trim());
            myParametroSQL = (myParametroSQL.Replace("\n", "").Trim());
            var DirectoryName = (Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            var myParametros = (new H_SQLiteConnectionStringBuilder()
            {
                @SetStringBuilder1_DataSource = (FileNameComExtencao),
                @SetStringBuilder2_Password = (Passwd),
            });
            //Default Return
            myReturn_String = (H_SQLiteDatabase.SQLExecuteNonQuery(@myParametros: myParametros,
                                                                   @myParametroSQL: myParametroSQL));
            //Retorno do metodo
            return (myReturn_String);
        }

        /// <summary>
        /// #H Metodo ExecuteSQLReturnDatasetDefault() - Roda Somente no Banco Default
        /// </summary>
        /// <param name="myParametroSQL">String como Parametros</param>
        /// <param name="myParametroSaida">String como Parametro Saida</param>
        /// <returns>Retorna Status</returns>
        public static DataSet ExecuteSQLReturnDatasetDefault(String myParametroSQL, ref String myParametroSaida)
        {
            //Default Return
            var myReturn_DataSet = (new DataSet());
            myParametroSQL = (myParametroSQL.Replace("\t", "").Trim());
            myParametroSQL = (myParametroSQL.Replace("\n", "").Trim());
            var DirectoryName = (Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            var myParametros = (new H_SQLiteConnectionStringBuilder()
            {
                @SetStringBuilder1_DataSource = (FileNameComExtencao),
                @SetStringBuilder2_Password = (Passwd),
            });
            myReturn_DataSet = (H_SQLiteDatabase.ExecuteSQLReturnDataset(@myParametros: myParametros,
                                                        @myParametroSQL: myParametroSQL,
                                                        @myParametroSaida: ref myParametroSaida));
            //Retorno do metodo
            return (myReturn_DataSet);
        }
        /// <summary>
        /// #H Metodo ExecuteSQLReturnDataTableDefault() - Roda Somente no Banco Default
        /// </summary>
        /// <param name="myParametroSQL">String como Parametros</param>
        /// <param name="myParametroSaida">String como Parametro Saida</param>
        /// <returns>Retorna Status</returns>
        public static DataTable ExecuteSQLReturnDataTableDefault(String myParametroSQL, ref String myParametroSaida)
        {
            //Default Return
            var myReturn_DataTable = (new DataTable());
            myParametroSQL = (myParametroSQL.Replace("\t", "").Trim());
            myParametroSQL = (myParametroSQL.Replace("\n", "").Trim());
            var DirectoryName = (Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            var myParametros = (new H_SQLiteConnectionStringBuilder()
            {
                @SetStringBuilder1_DataSource = (FileNameComExtencao),
                @SetStringBuilder2_Password = (Passwd),
            });
            myReturn_DataTable = (H_SQLiteDatabase.ExecuteSQLReturnDataTable(@myParametros: myParametros,
                                                            @myParametroSQL: myParametroSQL,
                                                            @myParametroSaida: ref myParametroSaida));
            //Retorno do metodo
            return (myReturn_DataTable);
        }
    }
}
