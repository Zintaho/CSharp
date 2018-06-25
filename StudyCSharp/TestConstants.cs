using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    class TestConstants : ITester
    {
        const int cInt = 30;
        readonly int rInt = 40;
        readonly int rIntAfter;

        public TestConstants()
        {
            rIntAfter = 50;
        }
        public TestConstants(int r)
        {
            rIntAfter = r;
        }
        void ITester.Test()
        {
            string str = cInt.ToString() + ' ' + rInt.ToString() + ' ' + rIntAfter.ToString();
            Console.WriteLine(str);
        }
    }
}
