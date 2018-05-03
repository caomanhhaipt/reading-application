using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule8 : Rule
    {
        public override bool IsValid(string str)
        {
            string check = "ÁÀẢẠÃ"
                + "ĂẮẰẶẲẴ"
                + "ÂẤẦẨẬẪ"
                + "ÉÈẺẸẼ"
                + "ÊẾỀỂỆỄ"
                + "ÍÌỈỊĨ"
                + "ÓÒỎỌÕ"
                + "ÔỐỒỔỘỖ"
                + "ỚỜỞỢỠ"
                + "ÚÙỦỤŨ"
                + "ỨỪỬỰỮ"
                + "ÝỲỶỴỸ";

            string tmp = str.ToUpper();

            int count = 0;
            for(int i = 0; i < tmp.Length; i++)
            {
                if(check.Contains("" + tmp[i]))
                {
                    count += 1;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt không được phép có từ hai ký tự có dấu trở lên");
        }
    }
}
