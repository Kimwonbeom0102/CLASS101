using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2  // Main 네임스페이스 외로 다른 네임스페이스 생성
{

    class Program  // Main 메서드를 만들기 위한 class
    {
        public static void Main(string[] args)
        {

            int count = 3; // 변수 초기화 (값을 넣어주는 것)

            // 리스트 선언
            List<int> intList = new List<int>();  // 리스트는 배열의 크기를 지정해주지않음

            // 배열 선언
            int[] ints1 = new int[3] { 1, 2, 3 };  // 배열의 크기를 지정해줌

            // 배열에 값 저장
            ints1[0] = 1; // 인덱스
            ints1[1] = 2;
            ints1[2] = 5;

            // 리스트에 값 저장
            intList.Add(1);
            intList.Add(2);
            intList.Add(5);

            // 배열의 값 반복 출력
            for (int i = 0; i < 3; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("count는 0입니다.");
                }
                else if(i == 1)
                {
                    Console.WriteLine("count는 1입니다.");
                }
                else
                {
                    Console.WriteLine("count는 0이 아닙니다.");
                }

                Console.WriteLine(ints1[i]);
            }
            Console.WriteLine();

            // 리스트의 값 반복 출력
            foreach (int x in intList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            // while문을 통한 반복 출력
            while (count != 0)
            {
                Console.WriteLine(count);
                count--;
            }

            count++;
            switch (count)
            {
                case 0:
                    Console.WriteLine("count는 0입니다.");
                    break;
                case 1:
                    Console.WriteLine("count는 1입니다.");
                    break;
                case 2:
                    Console.WriteLine("count는 2입니다.");
                    break;
            }


            Console.ReadLine();
        }
    }

    public class Print  // class 생성하여 메서드, 필드 등 정의를 해줌
    {
        public void PrintHello()  //  PrintHello 함수 생성
        {   
            string text = "Hello Wonbeom!";  // 문자열을 받아 text 를 사용
            Console.WriteLine(text);  //  입력된 text 호출
            Console.ReadLine();  // 입력대기로 콘솔이 꺼지지않도록 함

        }

    }

    public class Calculator
    {
        
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("0으로는 나눌 수 없습니다.");
                return 0;
            }
            return a / b;
        }






        //public class Calculator
        //{

        //    public void calculation()
        //    {
        //        int a;
        //        int b;

        //        Console.WriteLine(" 첫 번째 숫자를 입력하세요. : ");
        //        a = int.Parse(Console.ReadLine());

        //        Console.WriteLine(" 두 번째 숫자를 입력하세요 : ");
        //        b = int.Parse(Console.ReadLine());

        //        Console.WriteLine("사칙연산을 하겠습니다");
        //        Console.WriteLine($"{a} + {b} = {a + b}");
        //        Console.WriteLine($"{a} - {b} = {a - b}");
        //        Console.WriteLine($"{a} * {b} = {a * b}");
        //        Console.WriteLine($"{a} / {b} = {a / b}");
        //        Console.ReadLine();

        //    }

        //}
    }

    

   
}
