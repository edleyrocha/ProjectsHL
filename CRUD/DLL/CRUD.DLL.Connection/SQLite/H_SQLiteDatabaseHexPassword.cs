﻿#region Copyright and License Information
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
    /// #H Class Convert (String to byte[]) and (mybyts[] to String)
    /// </summary>
    public class H_SQLiteDatabaseHexPassword
    {
        /// <summary>
        /// #H Metodo Construtor da Classe H_SQLiteDatabaseHexPassword()
        /// </summary>
        public H_SQLiteDatabaseHexPassword()
        {
        }
        /// <summary>
        /// #H Metodo Retona mybyts de uma string
        /// </summary>
        /// <param name="myString"> Parametro String </param>
        /// <returns> Retorno byte[] </returns>
        public static byte[] H_GetBytes(string myString)
        {
            byte[] bytes = new byte[myString.Length * sizeof(char)];
            System.Buffer.BlockCopy(myString.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        /// <summary>
        /// #H Metodo Retona string de um array byte
        /// </summary>
        /// <param name="mybyts"> Parametro Bytes </param>
        /// <returns> Retorna String </returns>
        public static string H_GetString(byte[] mybyts)
        {
            char[] chars = new char[mybyts.Length / sizeof(char)];
            System.Buffer.BlockCopy(mybyts, 0, chars, 0, mybyts.Length);
            return new string(chars);
        }
    }
}
