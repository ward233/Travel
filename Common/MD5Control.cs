using System;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class MD5Control
    {

        #region 加密
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="input">string需要加密的字符串</param>
        /// <returns>加密后的string</returns>
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        #endregion

        #region 比较密码
        /// <summary>
        /// 比较密码
        /// </summary>
        /// <param name="input">明文</param>
        /// <param name="hash">密码</param>
        /// <returns>bool</returns>
        public static bool VerifyMd5Hash(string input, string hash)
        {
            MD5 md5Hash = MD5.Create();
            string hashOfInput = GetMd5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}