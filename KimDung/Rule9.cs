using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule9 : Rule
    {
        public override bool IsValid(string str)
        {
            string consonant = "BCDĐGHKLMNPQRSTVX";
            string tmp = str.ToUpper();

            int countConsonant = 0;
            for(int i = 0; i < tmp.Length; i++)
            {
                if(consonant.Contains("" + tmp[i]))
                {
                    countConsonant += 1;
                }

                if (countConsonant > 5)
                {
                    return true;
                }
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Một từ tiếng việt có tối đa 5 phụ âm");
        }
    }
}
