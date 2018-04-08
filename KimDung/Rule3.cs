using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    class Rule3 : Rule
    {
        public override bool IsValid(string str)
        {
            string check = "QRSDĐKLXVB";

            Regex splipWord = new Regex(@"\w{1,}");

            try
            {
                foreach (Match item in splipWord.Matches(str))
                {
                    if (check.Contains("" + item.ToString().ToUpper()[item.Length - 1]))
                    {
                        return true;
                    }
                }
            }
            catch (Exception) { }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt không có các phụ âm Q, R, S, D, Đ, K, L, X, V, B ở cuối");
        }
    }
}
