using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Error
    {
        private ArrayList ArrayIndex;
        private ArrayList ArrayLen;

        public Error()
        {
            this.ArrayIndex = new ArrayList();
            this.ArrayLen = new ArrayList();
        }

        public ArrayList ARRAYINDEX
        {
            get { return ArrayIndex; }
            set { ArrayIndex = value; }
        }

        public ArrayList ARRAYLEN
        {
            get { return ArrayLen; }
            set { ArrayLen = value; }
        }
    }
}
