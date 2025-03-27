using System;
using System.Collections.Generic;
using System.IO;  // IO 네임스페이스로 Stream 사용 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            // StreamWriter /  StreamReader 클래스 ----------------------
            // Stream은 데이터를 쓰는 통로역할
            // StreamWriter 는 파일을 쓰기만함

            Console.WriteLine("StreamWriter / StreamReader ----------\r\n");
            Console.WriteLine("파일 쓰기");
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)); // 파일 생성할 때 파일 이름을 넣어주고, 파일모드로 어떤작업을 할 지 결정
            // 스트림을 사용하고 입력           //  파일을 생성

            sw.Write(10);             // 같은 메서드지만 다른 매개변수를 받음 즉, 메서드 오버로딩 (같은 이름 다른 형태)
            sw.WriteLine("Hello");  // 문자열 string 매개변수
            sw.WriteLine(3.9131);     // 실수   매개변수
            sw.Close();               // 스트림을 사용했으면 닫아줌


            // StreamReader Open 으로 열기 모드
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            Console.WriteLine("파일 읽기");

            while(sr.EndOfStream == false)  // 스트림 끝점에 다다르게되면 while문 종료
            {
                Console.WriteLine(sr.ReadLine());  // 종료되기전까지는 StreamLeader 에서 한줄씩 가져와 출력
            }

            sr.Close();

            

            // using 키워드를 사용하여 생성하면 Close 로 닫아줄 필요가 없어서 자주 사용

            using (StreamWriter sw1 = new StreamWriter(new FileStream("b.txt", FileMode.Create)))
            {
                sw1.WriteLine("using 키워드로 텍스트 파일 만들기");
                sw1.WriteLine("Close로 닫아줄 필요가 없음");
                sw1.WriteLine("자주 사용하기에 좋다");
                sw1.Write(1);
                sw1.Write(2);
            }

            StreamReader sr1 = new StreamReader(new FileStream("b.txt", FileMode.Open));
            while(sr1.EndOfStream == false)
            {
                Console.WriteLine(sr1.ReadLine());
            }


            // File 클래스를 사용하여, 간단하게 파일로 출력하기 ----------------------
            // File.WriteAllText(path, text)는 지정한 경로에 텍스트 파일을 생성하고, 지정된 내용을 파일에 씁니다.만약 경로에 파일이 이미 존재한다면, 해당 파일을 덮어쓰고 새로 저장합니다.
            // File.WriteAllLines(path, lines)도 마찬가지로 배열로 받은 여러 문자열을 하나의 텍스트 파일에 한 줄씩 저장하며, 파일이 없다면 자동으로 생성됩니다.

            Console.WriteLine(Environment.NewLine + "File 클래스 사용 ---------" + Environment.NewLine);

            // 한줄씩 쓰고
            string[] lines = { "aaaa", "bbbb", "cccc" };  // 세 개의 문자열을 배열로 저장
            // File 클래스의 WriteAllLines 메서드를 통해 쓸 수 있음
            File.WriteAllLines("c.txt", lines);  // 저장해둔 문자열 배열 모두를 쓸 수 있음 (파일을 열고 문자열 파일을 모두 쓴 후 닫음)
           
            // 한줄씩 읽음
            string[] lines1 = File.ReadAllLines("c.txt"); // 텍스트 파일을 모두 읽은 후 파일을 닫는 메서드를 가져와 닫아주는것을 저장하고 lines1에 담아줌
            foreach(string line in lines1)
            {
                Console.WriteLine(line);
            }

            string text = "Hello World!";
            // 첫번째 방법
            string filePath = @"C:\Users\82106\source\repos\ConsoleApp1\FileHandling\bin\Debug.txt";
            File.WriteAllText(filePath, text);
            Console.WriteLine(File.ReadAllText(filePath));

            // 지정한 모든 텍스트를 씀
            // File.WriteAllText 메서드가 해당 경로에 파일을 자동으로 만들어줌 )이름 Debug.txt
            // 두번째 방법
            File.WriteAllText(@"C:\Users\82106\source\repos\ConsoleApp1\FileHandling\bin\Debug.txt", text);
            Console.WriteLine(File.ReadAllText(@"C:\Users\82106\source\repos\ConsoleApp1\FileHandling\bin\Debug.txt"));

            // 생성된 파일의 이름을 바꾸려면 Fil.Move 메서드 사용하여 기존 파일 경로, 새로운 파일 경로 
            


            Console.WriteLine("파일 쓰기");
            StreamWriter sw2 = new StreamWriter(new FileStream("wonbeom.txt", FileMode.Create));
            sw2.WriteLine("김원범");
            sw2.Write("생년월일 930102");
            sw2.WriteLine("지역 안산");

            sw2.Close();

            StreamReader sr2 = new StreamReader(new FileStream("wonbeom.txt", FileMode.Open));
            Console.WriteLine("파일 읽기");

            while(sr2. EndOfStream == false) // 끝이 아니면 계속 반복
            {
                Console.WriteLine(sr2.ReadLine());

            }

            sr2.Close();

            //Console.ReadLine();

            using (StreamWriter sw3 = new StreamWriter(new FileStream("kim.txt", FileMode.Create)))
            {
                sw3.WriteLine("김원범 정보");
                sw3.WriteLine("32세");
                sw3.WriteLine("안산 거주");
                sw3.Write("원곡동");

            }

            StreamReader sr3 = new StreamReader(new FileStream("kim.txt", FileMode.Open));
            while (sr3.EndOfStream == false)
            {
                Console.WriteLine(sr3.ReadLine());
            }

            //Console.ReadLine();

            Console.WriteLine(Environment.NewLine + "File 클래스 사용 예제 ---------" + Environment.NewLine);

            string[] strings = { "나는", "C#을", "공부중이고", "이건 미션이다." };

            File.WriteAllLines("c#미션.txt", strings);
            string[] strings1 = File.ReadAllLines("c#미션.txt");

            foreach (string s in strings1)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }
        

    }
}
