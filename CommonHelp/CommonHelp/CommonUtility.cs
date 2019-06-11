using NLog;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace CommonHelp.CommonHelp
{
    public class CommonUtility
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();
        public static JavaScriptSerializer Jss = new JavaScriptSerializer();


        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="intput">输入字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1Encrypt(string intput)
        {
            byte[] StrRes = Encoding.Default.GetBytes(intput);
            HashAlgorithm mySHA = new SHA1CryptoServiceProvider();
            StrRes = mySHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte Byte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", Byte);
            }
            return EnText.ToString();
        }
    }
}
