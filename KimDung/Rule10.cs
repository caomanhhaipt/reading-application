using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule10 : Rule
    {
        public override bool IsValid(string str)
        {
            string vowel = "AÁÀẢẠÃ"
                + "ĂẮẰẶẲẴ"
                + "ÂẤẦẨẬẪ"
                + "EÉÈẺẸẼ"
                + "ÊẾỀỂỆỄ"
                + "IÍÌỈỊĨ"
                + "OÓÒỎỌÕ"
                + "ÔỐỒỔỘỖ"
                + "ƠỚỜỞỢỠ"
                + "UÚÙỦỤŨ"
                + "ƯỨỪỬỰỮ"
                + "YÝỲỶỴỸ";
            string consonant = "BDĐKLMPQSTVX";
            string tmp = str.ToUpper();

            String formatStr = "";

            for(int i = 0; i < tmp.Length; i++)
            {
                if(vowel.Contains("" + tmp[i]) || consonant.Contains("" + tmp[i]))
                {
                    formatStr += tmp[i];
                }
            }

            for(int i = 1; i < formatStr.Length - 1; i++)
            {
                if(consonant.Contains("" + formatStr[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Một từ tiếng việt, các phụ âm không được phép đứng giữa" +
                "B, D, Đ, K, L, M, P, Q, S, T, V, X");
        }
    }
}
