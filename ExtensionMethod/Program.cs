using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod       //  확장메서드 정의
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "hello";  // 확장메서드는 클래스의 객체를 생성하지 않고 변수만 선언만 해줌
            result.Print();           // 변수.메서드(); 로   class.Method() 처럼 호출.  즉 확장메서드에서 만들어놓은 

            int result1 = 3;             // 정수형 변수 result2에 3 선언
            int result2 = 0;             // 정수형 변수 result2에 0 선언
            result2 = result1.Plus(3);   // // result 에 result1.Plus(3) 을 넣어줌.   =>  result1 = 3; = this int a , 나머지 매개변수 int b = 3  즉 3.Plus(3) return = 3 + 3
            
            Console.WriteLine(result2);  //  3 호출

            int result3 = 5.Minus(2);
            //int result4 = 0;
            //result4 = result3.Minus(2);
            Console.WriteLine(result3);

            int result5 = 4.Multiply(4, 2);
            Console.WriteLine(result5);


            StaticClass.Print();                      //  클래스의 원형.메서드 호출

            StaticClass class1 = new StaticClass();   // 객체 생성 
            class1.Print1();                          // 인스턴스.메서드 호출

            Console.ReadLine();
        }
    }

    class StaticClass
    {
        public static void Print()       //  Print 확장메서드
        {
            Console.WriteLine("Hello!");
            Console.ReadLine();
        }

        public void Print1()
        {
            Console.WriteLine("Hello!");
        }
    }

   


}
