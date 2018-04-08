using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controller
{
    class Rule1 : Rule
    {
        public override bool IsValid(string str)
        {
            Regex invalid = new Regex(@"(\w{1,})");

            foreach (Match item in invalid.Matches(str))
            {
                if (item.ToString().Length > 7)
                {
                    return true;
                }
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Chữ tiếng việt không dài quá 7 ký tự");
        }
    }
}
