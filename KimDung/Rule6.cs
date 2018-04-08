using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Rule6 : Rule
    {
        public override bool IsValid(string str)
        {
            string check = "AÁÀẢẠÃ"
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

            string tmp = str.ToUpper();

            int count = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (check.Contains("" + tmp[i]))
                {
                    count += 1;
                }
            }

            if (1 <= count && count <= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void Explain()
        {
            Console.WriteLine("Từ tiếng việt có ít nhất 1 nguyên âm và nhiều nhất 3 nguyên âm");
        }
    }
}
