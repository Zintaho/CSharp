using System;
namespace StudyCSharp
{
    class TestFlags : ITester
    {
        [Flags]
        enum TestEnum
        {
            A = 1,
            B = 2,
            C = 4,
            D = 8
        }

        void ITester.Test()
        {
            TestEnum t = TestEnum.B | TestEnum.C;
            Console.WriteLine((int)t);
        }
    }
}
