using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2; // 다른 네임스페이스를 가져와서 사용 (다른 라이브러리를 사용)


namespace Main
{
    // ConsoleApp2 네임스페이스 안에 생성해놓은 class를 인스턴스화 하여 메서드를 호출하여 다른 네임스페이스의 클래스, 메서드를 사용가능
    internal class Program
    {
        static void Main(string[] args)
        {

            Print print = new Print(); // 참조했던 네임스페이스에서 만들어놓은 클래스의
                                       // 인스턴스화 (Print class 재정의 사용 후 초기화)
            print.PrintHello(); // 재정의 한 인스턴스로 함수 호출


            //Calculator cal = new Calculator();
            //cal.calculation();

            Calculator calculator = new Calculator();

            Console.WriteLine("계산기입니다. 숫자를 입력해주세요");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("숫자를 입력해주세요");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("사친연산을 입력해주세요(+,-,*,/ )");
            char op = Console.ReadLine()[0];

            int result = 0;

            switch (op)
            {
                case '+':
                    result = calculator.Plus(a, b);
                    break;
                case '-':
                    result = calculator.Minus(a, b);
                    break;
                case '*':
                    result = calculator.Multiply(a, b);
                    break;
                case '/':
                    result = calculator.Divide(a, b);
                    break;
                default:
                    Console.WriteLine("연산자가 올바르지 않습니다.");
                    return;
            }

            Console.WriteLine($"결과: {a} {op} {b} = {result}");
            Console.ReadLine();



        }
    }

    class Car
    {
        // 일반적인 필드 예
        int field = 1;              // 4 바이트 정수
        long field1 = 11;           // 8 바이트 정수
        char field2 = 'a';          // 2 바이트 유니코드 문자
        float field3 = 1.1f;        // 4 바이트 실수
        double field4 = 1.1;        // 8 바이트 실수
        string field5 = "aaaa";     // 가변 사이즈 문자열
        bool field6 = true;

        // 일반적인 프로퍼티 예
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // public 프로퍼티 / 자동구현 프로퍼티 예 1
        public int Speed { get; set; }

        // 자동구현 프로퍼티 예 2 (get만 허용)
        public int Speed1 { get; private set; }

    }
}
