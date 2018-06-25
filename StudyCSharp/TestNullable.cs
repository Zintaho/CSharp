/*C# 2.0에서 추가된 Nullable은, value type이 null을 가질 수 있도록 만든 자료형이다.
 *bool? name 과 같이, value type명에 ?를 붙이거나,
 * Nullable<value type> name과 같이 선언한다.
 * 
 * value type으로의 변환은 name.Value
*/
using System;

namespace StudyCSharp
{
    class TestNullable : ITester
    {
        public int? nullableA;
        public Nullable<int> nullableB;

        void ITester.Test()
        {
            nullableA = nullableA ?? 101;
            nullableB = 202;

            int k = nullableB.Value;

            Print(nullableA);
            Print(nullableB);
            Print(k);
        }
        private void Print<T>(T data)
        {
            string str = data.GetType().ToString() + ' ' + data.ToString();
            Console.WriteLine(str);
        }
    }
}
