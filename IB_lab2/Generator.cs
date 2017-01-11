using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_lab2
{
    class Generator
    {
        int count_symb;
        Random rand;

        internal enum Type { Key, S }

        internal Generator(Type type)
        {
            if (type == Type.Key)
            {
                count_symb = 32;
            }
            else
            {
                count_symb = 8;
            }
        }

        public string Generate_key()
        {
            string strKey = "";
            rand = new Random();
            for(int i = 0; i < count_symb; i++)
            {
                strKey += (char)rand.Next(0x0040, 0x007E);
            }
            return strKey;
        }
    }
}
