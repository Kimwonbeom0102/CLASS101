using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadAndTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(TestThread0);

            
            //Task t1 = new Task(TestThread1, null);  // 매개변수가 있는 메서드 null값을 넣어줌
            Task t1 = new Task(new Action(TestThread1));    // 매개변수가 없는 메서드는 null값 없음
            t1.Start();
            Thread t2 = new Thread(TestThread2);
            t2.Start();
            var t3 = Task.Run(TestThread3);

           
            Console.WriteLine("main입니다.");

            // 호출이 완료될 때까지 대기
            t1.Wait();
            t2.Join();
            t3.Wait();

            // 스레드의 현재 상태 확인 (메인 스레드에서 실행)--------------
            Console.WriteLine("---- 스레드 상태 확인 (메인 스레드에서 실행)----");
            Console.WriteLine("Thread 1: " + t1.Status);
            Console.WriteLine("Thread 2: " + t2.ThreadState);
            Console.WriteLine("Thread 3: " + t3.Status);
            Console.WriteLine("-------------------------");

            Console.ReadLine();

        }

        // 매개변수가 없는 메서드 : Task.Run() 또는 new Task()에서 메서드를 그대로 전달
        // 매개변수가 있는 메서드 : Task.Run) 또는 new Task()에서 델리게이트를 사용하여 메서드와 매개변수를 함께 전달
        // 즉, 매개변수가 없는 메서드는 Task에 메서드 이름만 전달. 매개변수가 있는 메서드는 델리게이트사용해 매개변수 함께 전달


        static void TestThread0(object obj)
        {
            Console.WriteLine("---(별도의 스레드에서 실행)---");
            Console.WriteLine("Thread 0 입니다.");
        }

        static void TestThread1()
        {
            Console.WriteLine("---(별도의 스레드에서 실행)---");
            Console.WriteLine("Thread 1 입니다");
        }

        static void TestThread2(object obj)
        {
            Console.WriteLine("---(별도의 스레드에서 실행)---");
            Console.WriteLine("Thread 2 입니다");
        }

        static void TestThread3()
        {
            Console.WriteLine("---(별도의 스레드에서 실행)---");
            Console.WriteLine("Thread 3 입니다");
        }

    }




}
