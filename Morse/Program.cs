using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int frequency = 500;
            int dot = 200;
            int dash = 600;
            string morse = " ";
            Console.WriteLine("모스 부호로 바꿀 문자 및 숫자를 입력하세요");
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                char ch = c;

                if (c.Equals(' '))
                {
                    Thread.Sleep(800);
                }
                if (c >= 'a' && c <= 'z') { ch = char.Parse(c.ToString().ToUpper()); }  // 문자열이 소문자면 대문자로 바꿔주고 문자열로 담아줌

                switch (ch)
                {
                    case ' ': morse = " "; break;
                    case 'A': morse = ". - "; break;
                    case 'B': morse = "- . . . "; break;
                    case 'C': morse = "- . - . "; break;
                    case 'D': morse = "- . . "; break;
                    case 'E': morse = ". "; break;
                    case 'F': morse = ". . - . "; break;
                    case 'G': morse = "- - ."; break;
                    case 'H': morse = ". . . ."; break;
                    case 'I': morse = ". ."; break;
                    case 'J': morse = ". - - - "; break;
                    case 'K': morse = "- . - "; break;
                    case 'L': morse = ". - . . "; break;
                    case 'M': morse = "- -"; break;
                    case 'N': morse = "- . "; break;
                    case 'O': morse = "- - - "; break;
                    case 'P': morse = ". - - . "; break;
                    case 'Q': morse = "- - . -"; break;
                    case 'R': morse = ". -  ."; break;
                    case 'S': morse = ". . ."; break;
                    case 'T': morse = " - "; break;
                    case 'U': morse = ". . - "; break;
                    case 'V': morse = ". . . -"; break;
                    case 'W': morse = ". - - "; break;
                    case 'X': morse = "- . . -"; break;
                    case 'Y': morse = "- . - - "; break;
                    case 'Z': morse = "- - . ."; break;
                    case '1': morse = ". - - - -"; break;
                    case '2': morse = ".. - - -"; break;
                    case '3': morse = ". . . - -"; break;
                    case '4': morse = ". . . .-"; break;
                    case '5': morse = ". . . . ."; break;
                    case '6': morse = "- . . . ."; break;
                    case '7': morse = "- - . . ."; break;
                    case '8': morse = "- - - . ."; break;
                    case '9': morse = "- - - - ."; break;
                    case '0': morse = "- - - - -"; break;
                }

                foreach (char ch1 in morse)
                {
                    if (ch1.Equals('.'))   // (ch1 == '.')  메서드를 사용하지않아도 가능 
                    {
                        Console.Beep(frequency, dot);  //  Beep 메서드로 주파수( 지속시간, 경고음 )
                    }
                    if (ch1 == '-')
                    {
                        Console.Beep(frequency, dash);
                    }

                    //if (ch1.Equals('.'))   
                    //{
                    //    Console.Beep(500, 200);   //  int형 정수를 직접 넣어줌
                    //}

                    //if (ch1 == '-')
                    //{
                    //    Console.Beep(500, 600);   // int형 정수를 직접 넣어줌
                    //}

                    if (ch1 == ' ')
                    {
                        Thread.Sleep(200);
                    }

                    Thread.Sleep(600);
                }
            }


        }
    }
}
