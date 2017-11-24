using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassB
    {
        bool check;
        public bool Check(int n)
        {
            check = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) check = false;
            }



                return check;
        }
    }
}
