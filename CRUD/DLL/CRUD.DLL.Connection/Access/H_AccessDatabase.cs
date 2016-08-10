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
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using ADOX;
using ADODB;
using System.IO;
namespace HOYLER.Data.Access
{
    /// <summary>
    /// #H Classe H_AccessDatabase
    /// </summary>
    public class H_AccessDatabase
    {
        /// <summary>
        /// #H Metodo Contrutor H_AccessDatabase()
        /// </summary>
        public H_AccessDatabase()
        {
        }
        /// <summary>
        /// #H Metodo CreateFileDB
        /// </summary>
        /// <param name="myPatchDB">String como Parametro</param>
        /// <returns>Retorna String</returns>
        public static String CreateFileDB(String myPatchDB, String myPassword = "")
        {
            //Default Retorno
            var myReturn_String = (String.Empty);
            try
            {
                // File Patch via myParametros
                var FilePatch = (myPatchDB);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(myPatchDB));
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
                //Catalog DB
                var cat = new ADOX.Catalog();
                var ConnectString = (String.Empty);
                //Catalog String
                if (myPassword == "")
                {
                    ConnectString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (myPatchDB));

                }
                else
                {
                    myPassword = (";Jet OLEDB:Database Password=" + myPassword + ";");
                    ConnectString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (myPatchDB) + myPassword);
                }

                //Catalog Create
                cat.Create(ConnectString);
                //TABLEs
                var tableCustomer = new Table();
                var tableAddresses = new Table();
                //TABLEs Name
                tableCustomer.Name = "Customer";
                tableAddresses.Name = "Addresses";
                //Customer_ID
                tableCustomer.Columns.Append("Customer_ID", ADOX.DataTypeEnum.adInteger);
                tableCustomer.Keys.Append("PrimaryKEy", KeyTypeEnum.adKeyPrimary, "Customer_ID");
                tableCustomer.Columns["Customer_ID"].ParentCatalog = cat;
                tableCustomer.Columns["Customer_ID"].Properties["AutoIncrement"].Value = true;
                tableCustomer.Columns["Customer_ID"].Properties["Nullable"].Value = false;
                tableCustomer.Columns.Append("Name", ADOX.DataTypeEnum.adVarWChar, 50);
                tableCustomer.Columns.Append("Email", ADOX.DataTypeEnum.adVarWChar, 50);
                tableCustomer.Columns.Append("TelNumber", ADOX.DataTypeEnum.adVarWChar, 32);
                tableCustomer.Columns.Append("Fax", ADOX.DataTypeEnum.adVarWChar, 32);
                tableCustomer.Columns.Append("Street", ADOX.DataTypeEnum.adVarWChar, 50);
                tableCustomer.Columns.Append("PostalCode", ADOX.DataTypeEnum.adInteger, 10);
                tableCustomer.Columns.Append("City", ADOX.DataTypeEnum.adVarWChar, 50);
                tableCustomer.Columns.Append("AdressCounter", ADOX.DataTypeEnum.adSmallInt);

                tableAddresses.Columns.Append("Address_ID", ADOX.DataTypeEnum.adInteger);
                tableAddresses.Keys.Append("PrimaryKEy", KeyTypeEnum.adKeyPrimary, "Address_ID");
                tableAddresses.Columns["Address_ID"].ParentCatalog = cat;
                tableAddresses.Columns["Address_ID"].Properties["AutoIncrement"].Value = true; // Auto Incremente
                tableAddresses.Columns.Append("Street", ADOX.DataTypeEnum.adVarWChar, 50);
                tableAddresses.Columns["Street"].ParentCatalog = cat;
                tableAddresses.Columns["Street"].Properties["Nullable"].Value = true; //Default is FALSE
                tableAddresses.Columns.Append("PostalCode", ADOX.DataTypeEnum.adInteger);
                tableAddresses.Columns["PostalCode"].ParentCatalog = cat;
                tableAddresses.Columns["PostalCode"].Properties["Nullable"].Value = true; //Default is FALSE
                tableAddresses.Columns.Append("City", ADOX.DataTypeEnum.adVarWChar, 50);
                tableAddresses.Columns["City"].ParentCatalog = cat;
                tableAddresses.Columns["City"].Properties["Nullable"].Value = true; //Default is FALSE
                // FK ForeignKey_Customer_ID
                tableAddresses.Columns.Append("Customer_ID", ADOX.DataTypeEnum.adInteger); // FK
                tableAddresses.Keys.Append("ForeignKey_Customer_ID", ADOX.KeyTypeEnum.adKeyForeign, "Customer_ID", "Customer", "Customer_ID");

                //Append Tables on Catalog.
                cat.Tables.Append(tableCustomer);
                cat.Tables.Append(tableAddresses);

                // Close Catalog
                var ConnectionAccess = cat.ActiveConnection as ADODB.Connection;
                if (ConnectionAccess != null)
                {
                    ConnectionAccess.Close();
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
        public static String CreateFileDBClean(String myPatchDB, String myPassword = null)
        {
            //Default Retorno
            var myReturn_String = (String.Empty);
            try
            {
                // File Patch via myParametros
                var FilePatch = (myPatchDB);
                // Check DirectoryName Exists
                var DirectoryName = (Path.GetDirectoryName(myPatchDB));
                if (!Directory.Exists(DirectoryName))
                {
                    // Check DirectoryName Exists - ERRO
                    throw new ArgumentException("Erro DirectoryName Name (00001) NOT Exists", "Metodo CreateFileDBClean()");
                };
                // Check File Exists 
                if (File.Exists(FilePatch))
                {
                    // Check File Exists - ERRO
                    throw new ArgumentException("Erro File Name (00002) Exists", "Metodo CreateFileDBClean()");
                };
                //Catalog DB
                var cat = new ADOX.Catalog();
                var ConnectString = (String.Empty);
                //Catalog String
                if (myPassword == null)
                {
                    ConnectString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (myPatchDB));

                }
                else
                {
                    myPassword = (";Jet OLEDB:Database Password=" + myPassword + ";");
                    ConnectString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + (myPatchDB) + myPassword);
                }

                //Catalog Create DB
                cat.Create(ConnectString);

                // Close Catalog
                var ConnectionAccess = cat.ActiveConnection as ADODB.Connection;
                if (ConnectionAccess != null)
                {
                    ConnectionAccess.Close();
                };
                // Check File NOT Exists 
                if (!File.Exists(FilePatch))
                {
                    // Check File NOT Exists - ERRO
                    throw new ArgumentException("Erro File Name (00003) NOT Exists", "Metodo CreateFileDBClean()");
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

    }
}
