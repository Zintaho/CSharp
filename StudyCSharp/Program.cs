/*const는 컴파일시에 값이 결정되는 상수 (필드 선언시에만 초기화 가능
 * readonly는 런타임시에 값이 결정되는 상수(필드 선언시나,  클래스 생성자에서 대입)
 */
using System;
namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITester tester = new TestNullable();
            tester.Test();

            return;
        }
    }
}
