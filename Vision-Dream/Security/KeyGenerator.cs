#region Proprietary Information
/* 
    * Created by:   Vision-Dream ICT Solutions
    * Author:       Onkgopotse Lenake
    * Email:        visiondreamict@gmail.com
    * Website:      www.visiondreamict.wordpress.com
    * 
    *               (c) 2019 Vision-Dream ICT Solutions. All rights reserved.
    * _______________________________________________________________________
    * Project:      Vision-Dream .Net Core 2.2 (Vision-Dream) Library
    *               Project Targeting .Net Core 2.2.
    * Version:      v1.0.0
    * File:         KeyGenerator.cs
    * Date:         2019-01-10
    * Description:  This file contains the KeyGenerator class. 
    *               Class execution code.
*/
#endregion

using System;
using System.Text;
using System.Security.Cryptography;

namespace Vision_Dream.Security
{
    public static class KeyGenerator
    {
        public static string GetUniqueKey(int maxSize = 15)
        {
            try
            {
                var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                byte[] data = new byte[1];
                using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
                {
                    crypto.GetNonZeroBytes(data);
                    data = new byte[maxSize];
                    crypto.GetNonZeroBytes(data);
                }

                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }

                return result.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
