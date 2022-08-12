using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Common
{
    public class Hash256
    {
        static public string SHA256EncryptString(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256Managed.Create().ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }
            return builder.ToString();
        }

        static public string SHA256Encryptbytes(byte[] bytes)
        {
            byte[] hash = SHA256Managed.Create().ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }
            return builder.ToString();
        }

        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="StrIn">待加密字符串</param>
        /// <returns>加密数组</returns>
        public Byte[] SHA256EncryptByte(string StrIn)
        {
            var sha256 = new SHA256Managed();
            var Asc = new ASCIIEncoding();
            var tmpByte = Asc.GetBytes(StrIn);
            var EncryptBytes = sha256.ComputeHash(tmpByte);
            sha256.Clear();
            return EncryptBytes;
        }


    }
}
