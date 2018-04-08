using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    class Rule5 : Rule
    {
        public override bool IsValid(string str)
        {
            string check = "NHNGCH";
            string consonant = "BCDĐGHKLMNPQRSTVX";

            Regex splipWord = new Regex(@"\w{1,}");

            try
            {
                foreach (Match item in splipWord.Matches(str))
                {
                    if (consonant.Contains("" + item.ToString().ToUpper()[item.Length - 2])
                    && consonant.Contains("" + item.ToString().ToUpper()[item.Length - 1]))
                    {
                        int i = 0;
                        for (; i < check.Length; i += 2)
                        {
                            if (check[i] == item.ToString().ToUpper()[item.Length - 2]
                                && check[i + 1] == item.ToString().ToUpper()[item.Length - 1])
                            {
                                break;
                            }
                        }

                        if (i >= check.Length)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception) { }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt nếu có 2 phụ âm đứng cuối thì bắt buộc phải là:"
               + "NH, NG, CH");
        }
    }
}
