using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    public class Common
    {
        public const string _spridId = "b9318db41ddf4a2da5ed5fa0a6893bc7";
        public const string _orderno = "ZF201710187564VBj2lA";
        public const string secret = "c02c70d6f7554fa2b3397417ee136a08";
        public const int _time = 1508383995;
        //82DE252F74286C2D47951D7EF7F96E6B
        public static string authHeader(String orderno, String secret)
        {
            int timestamp = ConvertDateTimeInt(DateTime.Now);

            //拼装签名字符串
            String planText = string.Format("orderno={0},secret={1},timestamp={2}", orderno, secret, timestamp);
            
            //计算签名
            String sign = GetMD5_1(planText);
            //拼装请求头Proxy-Authorization的值
            string authHeader = string.Format("sign={0}&orderno={1}&timestamp={2}", sign, orderno, timestamp);
            return authHeader;
        }

        /// <summary>
        /// 实际获取结果
        /// </summary>
        /// <returns></returns>
        public static string GetIpList()
        {
            string res = string.Empty;
            string ip = "forward.xdaili.cn";
            //ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;
            WebClient wc = new WebClient();
            wc.Headers.Add("Proxy-Authorization", authHeader(_orderno, secret));
            wc.Proxy = new WebProxy(ip, 80);

            res = wc.DownloadString("http://pv.sohu.com/cityjson");
            //res = wc.DownloadString("https://www.baidu.com/");
            return res;
        }

        private static bool RemoteCertificateValidate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        /// <summary>
        /// 生成10位时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
        
        /// <summary>
        /// 获取MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5_1(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptedBytes = md5.ComputeHash(Encoding.Default.GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                sb.Append(encryptedBytes[i].ToString("x2"));
            }
            return sb.ToString().ToUpper();
        }
    }
}
