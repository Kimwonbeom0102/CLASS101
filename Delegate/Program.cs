using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate   //  델리게이트(대리자)
{
    // 델리게이트 (대리자) 정의
    delegate int Dele(int a , int b);  // 이 형태로 넘겨주면 다른 메서드는 이 형태를 가져야함

    class Program
    {
        static void Main(string[] args)
        {
            // 델리게이트 인스턴스 생성
            Dele plus = new Dele(Plus);
            Dele minus = new Dele(Minus);
            Dele multy = new Dele(Multiply);

            // 델리게이트를 매개변수로 하는 메서드를 호출
            Calc(1, 2, Plus);
            Calc(5, 3, Minus);
            Calc(2, 4, Multiply);


            Console.ReadLine();
        }
        
        // 델리게이트를 매개변수로 받는 메서드
        static void Calc(int a, int b, Dele dele) 
        {
            Console.WriteLine(dele(a, b)); //  델리게이트에 어떤 값 2개를 넣은 값을 출력
        }
        
        //델리게이트로 다른 메서드에 넘겨줄 메서드 (생성한 델리게이트의 형태)
        static int Plus(int a, int b) // static으로 만들어주면 class 직접 호출
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
