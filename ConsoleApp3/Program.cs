using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1  // 다형성
{
    internal class Program : Calc
    {
        static void Main(string[] args)
        {
            Program program = new Program();  // Program 객체 생성
            int result = program.Plus(3, 1);  // Plus 메서드 호출 (매개변수는 3, 1)
            Console.WriteLine(result);  
            Console.ReadLine();
            
        }

        public override int Plus(int a, int b)  //  추상메서드 정의한 것을 상속시킨 Program class에 덮어써서 정의
        {
            // return a + b;  // 오버라이드는 정의하기 나름이기때문에 재정의가 가능함
            return a - b;
        }
    }

    abstract public class Calc  // 추상클래스 생성
    {
        abstract public int Plus(int a, int b);  // 추상메서드 정의
    }
}

