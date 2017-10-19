using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace RodenCore.Common
{

    /// <summary>
    /// http://blog.csdn.net/u010678947/article/details/48652875
    /// </summary>
    public class Encryption
    {
       public const string _pubKey = @"<RSAKeyValue><Modulus>2PL2IhyejmBk1HrSIcqXzBRvWLBY6I0GetQmMGj5taXa5uHaD3DN/aOxsLv/jnhVYBE/y0W9L1foEMruPHCRmG21ZKmgBy4AsfF2d51DRk7eD9OfMeOoRgglv1jDrORiF4OcQikoiLwEZoMOEGYrXGTQadANiBC4fc3AN1bC2rk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
       public const string _privKey = @"<RSAKeyValue><Modulus>2PL2IhyejmBk1HrSIcqXzBRvWLBY6I0GetQmMGj5taXa5uHaD3DN/aOxsLv/jnhVYBE/y0W9L1foEMruPHCRmG21ZKmgBy4AsfF2d51DRk7eD9OfMeOoRgglv1jDrORiF4OcQikoiLwEZoMOEGYrXGTQadANiBC4fc3AN1bC2rk=</Modulus><Exponent>AQAB</Exponent><P>8+yLBBo7HXSFB3lWd6La7z0yon4VzSMQkPlNoDApuCJorSTG/h1eLXOJqvMPr2EAAnrv05/3gTS5V3F0iGJ50Q==</P><Q>47CKyenpdw3L2HOCOhJYQlNQLUINq/C5IC14uFVb0F295eTB0uTJJ8Crk24vbFrsvVGDG5tEHAfcnHnNi0WkaQ==</Q><DP>Cf5N77wXYeyNKrI47avZZmXOdkPOJtph6l6cZIy0mNuoCDfygyS24AvUvxE4OkoyEufwfW4XWM7NLRzz1kaakQ==</DP><DQ>Hlx1NVV2p0R0sSk97UZy9G0tnMtZDVttJChMF7ByLMfDQbuOSPPvCtj7SA6CTl2Vge0zoWPD4kT+GvN3ACJKOQ==</DQ><InverseQ>FXgXJq0LkejL8BBbsHvSJKSJ4sLHGpo9hXoepDpY0Z+MGJkrjgeF8DjQD4YweO5idQxq7Hd3JtjSmMfSILP4xA==</InverseQ><D>0m5X755y7Qbyxmabi8tGkd0AY7YphufDcUB2Cl7IVzkYqvpG2NNB+tPcduDjcP2nUhdpGXH7nwBVSHSNwHIvxTCxQ0wgWBsqSl0Ib+1rUX8Kyc0HfqRCgpifmEZ0AxlMfrfamYy3LaLcLe2+8wKQNGqK/dv0H9OkS68usPb16AE=</D></RSAKeyValue>";


      

        #region RSA 的密钥产生  
        /// <summary>  
        /// RSA产生密钥  
        /// </summary>  
        /// <param name="xmlKeys">私钥</param>  
        /// <param name="xmlPublicKey">公钥</param>  
        public static void RSAKey(out string xmlKeys, out string xmlPublicKey)
        {
            try
            {
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                xmlKeys = rsa.ToXmlString(true);
                xmlPublicKey = rsa.ToXmlString(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region RSA 加密函数

        /// <summary>  
        /// RSA的加密函数  
        /// </summary>  
        /// <param name="xmlPublicKey">公钥</param>  
        /// <param name="encryptString">待加密的字符串</param>  
        /// <returns></returns>  
        public static string RSAEncrypt(string xmlPublicKey, string encryptString)
        {
            try
            {
                byte[] PlainTextBArray;
                byte[] CypherTextBArray;
                string Result;
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlPublicKey);
                PlainTextBArray = (new UnicodeEncoding()).GetBytes(encryptString);
                CypherTextBArray = rsa.Encrypt(PlainTextBArray, false);
                Result = Convert.ToBase64String(CypherTextBArray);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>  
        /// RSA的加密函数   
        /// </summary>  
        /// <param name="xmlPublicKey">公钥</param>  
        /// <param name="EncryptString">待加密的字节数组</param>  
        /// <returns></returns>  
        public static string RSAEncrypt(string xmlPublicKey, byte[] EncryptString)
        {
            try
            {
                byte[] CypherTextBArray;
                string Result;
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlPublicKey);
                CypherTextBArray = rsa.Encrypt(EncryptString, false);
                Result = Convert.ToBase64String(CypherTextBArray);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region RSA的解密函数          
        /// <summary>  
        /// RSA的解密函数  
        /// </summary>  
        /// <param name="xmlPrivateKey">私钥</param>  
        /// <param name="decryptString">待解密的字符串</param>  
        /// <returns></returns>  
        public static string RSADecrypt(string xmlPrivateKey, string decryptString)
        {
            try
            {
                byte[] PlainTextBArray;
                byte[] DypherTextBArray;
                string Result;
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlPrivateKey);
                PlainTextBArray = Convert.FromBase64String(decryptString);
                DypherTextBArray = rsa.Decrypt(PlainTextBArray, false);
                Result = (new UnicodeEncoding()).GetString(DypherTextBArray);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>  
        /// RSA的解密函数   
        /// </summary>  
        /// <param name="xmlPrivateKey">私钥</param>  
        /// <param name="DecryptString">待解密的字节数组</param>  
        /// <returns></returns>  
        public static string RSADecrypt(string xmlPrivateKey, byte[] DecryptString)
        {
            try
            {
                byte[] DypherTextBArray;
                string Result;
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlPrivateKey);
                DypherTextBArray = rsa.Decrypt(DecryptString, false);
                Result = (new UnicodeEncoding()).GetString(DypherTextBArray);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
