using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    class Rule7 : Rule
    {
        public override bool IsValid(string str)
        {
            Regex invalid = new Regex(@"(\w{1,}\W{1,}\w{1,})|(\w{1,}\d{1,})|(\d{1,}\w{1,})");

            foreach (Match item in invalid.Matches(str))
            {
                return true;
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt, các ký tự chữ không được phép đi "
               + "liền với cá ký tự khác chữ (trừ các dấu ở cuối mỗi từ)");
        }
    }
}
