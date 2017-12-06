using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace V5_WinLibs.Core {
    /// <summary>
    /// Des对称加密 解密
    /// </summary>
    public class DESHelper1 {
        #region ========加密========
        /// <summary>   
        /// DES加密方法   
        /// </summary>   
        /// <param name="strPlain">明文</param>   
        /// <param name="strDESKey">密钥</param>   
        /// <param name="strDESIV">向量 只能8位</param>   
        /// <returns>密文</returns>   
        public static string Encrypt(string source, string _DESKey) {
            StringBuilder sb = new StringBuilder();
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()) {
                byte[] key = ASCIIEncoding.ASCII.GetBytes(_DESKey);
                byte[] iv = ASCIIEncoding.ASCII.GetBytes(_DESKey);
                byte[] dataByteArray = Encoding.UTF8.GetBytes(source);
                des.Mode = System.Security.Cryptography.CipherMode.CBC;
                des.Key = key;
                des.IV = iv;
                string encrypt = "";
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write)) {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                    foreach (byte b in ms.ToArray()) {
                        sb.AppendFormat("{0:X2}", b);
                    }
                    encrypt = sb.ToString();
                }
                return encrypt;
            }

        }

        #endregion

        #region ========解密========
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text">加密的字符串</param> 
        /// <param name="sKey">加密Key 只能8位</param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey) {
            try {

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                int len;
                len = Text.Length / 2;
                byte[] inputByteArray = new byte[len];
                int x, i;
                for (x = 0; x < len; x++) {
                    i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Encoding.UTF8.GetString(ms.ToArray());

            }
            catch (Exception) {
                return string.Empty;
            }
        }

        #endregion
    }
}
