using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule
    {
        public virtual bool IsValid(string str)
        {
            return true;
        }

        public virtual void Explain()
        {
            Console.WriteLine("");
        }

        public static bool IsWord(string str)
        {
            string check = "ÁÀẢẠÃ" + "Đ"
                        + "ĂẮẰẶẲẴ"
                        + "ÂẤẦẨẬẪ"
                        + "ÉÈẺẸẼ"
                        + "ÊẾỀỂỆỄ"
                        + "ÍÌỈỊĨ"
                        + "ÓÒỎỌÕ"
                        + "ÔỐỒỔỘỖ"
                        + "ƠỚỜỞỢỠ"
                        + "ÚÙỦỤŨ"
                        + "ƯỨỪỬỰỮ"
                        + "ÝỲỶỴỸ";
            string tmp = str.ToUpper();

            for (int i = 0; i < tmp.Length; i++)
            {
                if ((check.Contains("" + tmp[i])) || (65 <= tmp[i] && tmp[i] <= 90))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
