using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism  //  메서드 오버로딩 네임스페이스 
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();  //  프로그램 객체 생성
            pro.PlusPrint(1, 1);          //  PlusPrint 호출 (int, int) -> 매개변수의 형태대로 아래 메서드를 호출
            
        }

        public void PlusPrint(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            Console.WriteLine("int 와 int를 더합니다");
            Console.ReadLine();
        }

        public void PlusPrint(int a, float b)
        {
            int result = a + Convert.ToInt32(b);
            Console.WriteLine(result);
            Console.WriteLine("int와 float를 더하기 합니다.");
            Console.ReadLine();
        } 
        
        public void PlusPrint(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
            Console.WriteLine("int 3개를 합니다.");
            Console.ReadLine();
        }

    }

   
}
