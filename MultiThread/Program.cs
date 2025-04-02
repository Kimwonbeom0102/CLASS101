using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\Users\82106\Desktop\testdata", "*.txt");
            foreach (string file in files)
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(Sum));
                t1.Start(file);
                Thread.Sleep(100);
            }

            Console.ReadLine();

        }

        static void Sum(object dataFile)
        {
            string[] lines = File.ReadAllLines(dataFile.ToString());
            int sum = 0;
            foreach(string line in lines)
            {
                sum += int.Parse(line.ToString());
            }

            Console.WriteLine("{0} : 합계 : {1} \r\n", dataFile, sum);

            Console.WriteLine($"{dataFile}의 합계 결과를 파일로 출력합니다");
            string name = dataFile.ToString().Split(',')[0];
            File.WriteAllText($"{name}_sum.txt", sum.ToString());
        }
    }
}
