using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule2 : Rule
    {
        public override bool IsValid(string str)
        {
            string tmp = str.ToUpper();
            if (tmp.Contains("W") | tmp.Contains("F")
                | tmp.Contains("J") | tmp.Contains("Z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt không chứa các ký tự w, f, j, z");
        }
    }
}
