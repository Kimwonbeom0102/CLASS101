using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiledHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileStream 클래스가 가지는 Position 프로퍼티를 통해 파일 스트림에 접근하기
            // 파일을 쓴 순서대로 저장
            
            Console.WriteLine("--------쓰기-------" + Environment.NewLine);
            Stream outstream = new FileStream("a.txt", FileMode.Create); // 객체를 생성할 때 포지션은 0이 된다
            outstream.WriteByte(0x01);
            Console.WriteLine($"Position : {outstream.Position}");     // WriteByte() 메서드를 호출 할 때마다 포지션이 1 증가

            outstream.WriteByte(0x02);
            Console.WriteLine($"Position : {outstream.Position}");  
            outstream.WriteByte(0x03);
            Console.WriteLine($"Position : {outstream.Position}");
            outstream.Seek(10, SeekOrigin.Current);                    // Seek 메서드 사용. 현재 위치에서 10바이트 뒤로 이동
            Console.WriteLine($"Position : {outstream.Position}");     // 임의 접근 방식
            outstream.WriteByte(0x04);
            Console.WriteLine($"Position : {outstream.Position}");
            Console.WriteLine();
            outstream.Close();

            Console.WriteLine("-------읽기------" + Environment.NewLine);
            Stream inStream = new FileStream("a.txt", FileMode.Open);
            inStream.ReadByte();
            Console.WriteLine($"Position : {inStream.Position}");
            inStream.ReadByte();
            Console.WriteLine($"Position : {inStream.Position}");
            inStream.ReadByte();
            Console.WriteLine($"Position : {inStream.Position}");
            inStream.Seek(10, SeekOrigin.Current);
            Console.WriteLine($"Position : {inStream.Position}");
            inStream.ReadByte();
            Console.WriteLine($"Position : {inStream.Position}");
            inStream.Close();
            Console.Read();


            // 파일 액세스 모드
            //Stream stream1 = new FileStream("a.dat", FileMode.Create);        // 새 파일 생성
            //Stream stream2 = new FileStream("b.dat", FileMode.Open);          // 파일 열기
            //Stream stream3 = new FileStream("c.dat", FileMode.OpenOrCreate);  // 있으면 열고, 없으면 생성
            //Stream stream4 = new FileStream("d.dat", FileMode.Truncate);      // 파일을 비워서 열기
            //Stream stream5 = new FileStream("e.dat", FileMode.Append);        // 덧붙이기 모드로 열기

            




        }
    }
}
