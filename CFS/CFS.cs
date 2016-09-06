using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CFS
{
    public class Cryptography
    {
        public static string CFS(string codeStr)
        {
            var CodeLen = 30;
            var CodeSpace = 0;
            var Been = 0;

            CodeSpace = CodeLen - codeStr.Length;
            if(CodeSpace > 1)
            {
                for(var cecr = 1; cecr <= CodeSpace; cecr++)
                {
                    codeStr = codeStr + Convert.ToChar(21);
                }
            }
            double NewCode = 1;

            for(var cecb = 1; cecb <= CodeLen; cecb++)
            {
                Been = CodeLen + ((int)codeStr[cecb - 1]) * cecb;
                NewCode = NewCode * Been;
            }

            var tmpNewCode = NewCode.ToString("0.###############E+0");   //to convert to the same precision as c# code
            codeStr = tmpNewCode.ToString().ToUpper();
            var NewCode2 = "";

            for(var cec = 1; cec <= codeStr.Length; cec++)
            {
                int posStart = cec - 1;
                int len = (codeStr.Length - posStart ) >= 3 ? 3 : (codeStr.Length - (cec - 1));
                NewCode2 = NewCode2 + CfsCode(codeStr.Substring(cec - 1, len));
            }

            var CfsEncodeStr = "";
            for(var cec = 20; cec <= NewCode2.Length - 18; cec += 2)
            {
                CfsEncodeStr = CfsEncodeStr + NewCode2[cec - 1];
            }
            return CfsEncodeStr.ToUpper();
        }

        private static string CfsCode(string nWord)
        {
            var num = "";
            for(var cc = 1; cc <= nWord.Length; cc++)
            {
                num += ((int)nWord[cc - 1]).ToString();
            }
            var result = Convert.ToInt64(num).ToString("X");
            return result;
        }

        public static string Md5Hash(string value)
        {
            var md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(value));
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
