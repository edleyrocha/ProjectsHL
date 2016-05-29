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
    /// # Class Convert (String to byte[]) and (bytes[] to String)
    /// </summary>
    public class SQLiteDatabaseHexPassword
    {
        /// <summary>
        /// # Metodo Construtor Simples
        /// </summary>
        public SQLiteDatabaseHexPassword()
        {

        }
        /// <summary>
        /// # Metodo Retona bytes de uma string
        /// </summary>
        /// <param name="str"> Parametro String </param>
        /// <returns> Retorno Bytes </returns>
        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        /// <summary>
        /// # Metodo Retona string de um array byte
        /// </summary>
        /// <param name="bytes"> Parametro Bytes </param>
        /// <returns> Retorna String </returns>
        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
