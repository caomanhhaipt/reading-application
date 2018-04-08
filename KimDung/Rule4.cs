using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule4 : Rule
    {
        public override bool IsValid(string str)
        {
            string check = "THTRPHKHNHCHGHNG";
            string consonant = "BCDĐGHKLMNPQRSTVX";

            if (consonant.Contains("" + str.ToUpper()[0])
                && consonant.Contains("" + str.ToUpper()[1]))
            {
                int i = 0;
                for (; i < check.Length; i += 2)
                {
                    if (check[i] == str.ToUpper()[0] && check[i + 1] == str.ToUpper()[1])
                    {
                        break;
                    }
                }

                if (i >= check.Length)
                {
                    return true;
                }
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt nếu có 2 phụ âm đứng đầu thì bắt buộc phải là:"
                 + "TH, TR, PH, KH, NH, CH, GH, NG");
        }
    }
}
