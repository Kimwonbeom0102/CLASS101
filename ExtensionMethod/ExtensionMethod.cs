using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod   //  확장메서드의 예시
{
    public static class ExtensionMethod
    {
        public static void Print(this string s)  // 매개변수에 this 키워드를 붙이면 확장메서드  sting class 의 Print 메서드 의 매개변수(s)
        {
            Console.WriteLine(s);     // "hello" 호출
        }

        public static int Plus(this int a ,int b) // 매개변수가 2개 일때 앞에 매개변수만 this 수식. 
        {
            return a + b;
        }

        public static void Print1(this int a ,int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        //미션

        public static int Minus(this int a ,int b)
        {
            return a - b;
        }

        public static int Multiply(this int a, int b, int c)
        {
            return (a * b ) - c;
        }
    }
}

