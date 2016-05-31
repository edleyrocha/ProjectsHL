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
    /// # Class Convert (String to byte[]) and (byts[] to String)
    /// </summary>
    public class SQLiteDatabaseHexPassword
    {
        /// <summary>
        /// # Metodo Construtor da Classe SQLiteDatabaseHexPassword()
        /// </summary>
        public SQLiteDatabaseHexPassword()
        {
        }
        /// <summary>
        /// # Metodo Retona byts de uma string
        /// </summary>
        /// <param name="strs"> Parametro String </param>
        /// <returns> Retorno byte[] </returns>
        public static byte[] GetBytes(string strs)
        {
            byte[] bytes = new byte[strs.Length * sizeof(char)];
            System.Buffer.BlockCopy(strs.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        /// <summary>
        /// # Metodo Retona string de um array byte
        /// </summary>
        /// <param name="byts"> Parametro Bytes </param>
        /// <returns> Retorna String </returns>
        public static string GetString(byte[] byts)
        {
            char[] chars = new char[byts.Length / sizeof(char)];
            System.Buffer.BlockCopy(byts, 0, chars, 0, byts.Length);
            return new string(chars);
        }
    }
}
