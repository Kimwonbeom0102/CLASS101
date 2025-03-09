using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacetest
{
    //class Car // Car가 아니라 Train이면 Car class 를 호출하는 클래스도 바뀌어야 한다.
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Run!");
    //    }
    //}

    //interface ITrans  // 인터페이스 Trans 교통범주 생성
    //{
    //    void Run();  // Run 호출  -> Run은 Move에서 만든 메서드. 즉 Move 클래스를 타고 감.
    //    void Run2();
    //}

    //class Car : ITrans
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Car run!");
    //        Console.ReadLine();
    //    }
    //    public void Run2()
    //    {
    //        Console.WriteLine("Car run2!");
    //        Console.ReadLine();
    //    }
    //}

    //class Trarin : ITrans  //  Train은 Trans의 범주 안에 속해있다.
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Train Run!");
    //        Console.ReadLine();
    //    }
    //    public void Run2()
    //    {
    //        Console.WriteLine("Train run2!");
    //        Console.ReadLine();
    //    }
    //}

    //class Move : Move1  // Move 클래스 생성
    //{
    //    public void Transport(ITrans trans)  //  Move 클래스의 Run이라는 메서드를 정의 => ITrans 인터페이스에서 호출. 매개변수 지정
    //    {
    //        trans.Run();  //  Trans.Run 실행 (Car)
    //        trans.Run2();
    //        Run1(trans);
    //    }
    //}

    //class Move1
    //{
    //    public void Run1(ITrans trans)  // Move1 클래스의 메서드를 정의해주고
    //    {
    //        Console.WriteLine("Run1!!");
    //        Console.ReadLine(); 
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Move move = new Move();    //  Move 객체 생성
    //        ITrans trans = new Trarin();  // ITrans 객체 생성(Car)
    //        move.Transport(trans);     // move.Transport(ITrans trans) 호출
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Move move = new Move();        //  Move 객체 생성
            ITrans trans = new Car();      // ITrans 객체 생성(Car)  Train도 가능
            ITrans trans1 = new Trarin();  // ITrans 객체생성 (Train) 으로 생성 
            Stop stop = new Stop();

            move.Transport(trans);     // move.Transport(ITrans trans) 호출
            move.Transport(trans1);    // move.Transport(ITrans trans - Train) 호출
            stop.Transport(trans);

            Working work = new Working();         //  Working 객체 생성
            IDevice cellphone = new Cellphone();  // Cellphone 객체 생성
            IDevice laptop = new Laptop();        // Laptop 객체 생성
            work.Work(cellphone, laptop);         // Working 메서드 호출 -> Cellphone, Laptop class - Work 메서드 호출

        }
    }


    interface ITrans  // 인터페이스 Trans 교통범주 생성, 즉 상속받는 class가 공통적으로 사용되는 메서드를 넣어줌
    {
        void Run();  // Run 선언만 해주고 구현은 각 Car, Train class에서 정의 및 구현
        void Stop();
    }

    class Car : ITrans
    {
        public void Run() 
        {
            Console.WriteLine("Car Run!!");
            Console.ReadLine();
        }

        public void Stop()
        {
            Console.WriteLine("Car Stop!!");
            Console.ReadLine();
        }
    }

    class Trarin : ITrans  //  Train은 Trans의 범주 안에 속해있다.
    {
        public void Run()
        {
            Console.WriteLine("Train Run!!");
            Console.ReadLine();
        }

        public void Stop()
        {
            Console.WriteLine("Car Stop!!");
            Console.ReadLine();
        }
    }

    class Move : Move1  // Move 클래스 생성
    {
        public void Transport(ITrans trans)  //  Move 클래스의 Run이라는 메서드를 정의. 매개변수로 Car 또는 Train의 개체가 들어오면 해당 클래스의 Run 메서드 실행
        {
            trans.Run();  //  Trans.Run 실행
            Run1();
        }
    }

    class Move1
    {
        public void Run1()  // Move1 클래스의 메서드를 정의해주고
        {
            Console.WriteLine("Run1!!");
            Console.ReadLine();
        }
    }

    class Stop
    {
        public void Transport(ITrans trans)
        {
            trans.Stop();  
        }
    }


    interface IDevice  //  장치에 대한 인터페이스 생성
    {
        void Work();  // 호출
    }

    class Cellphone : IDevice  // Cellphone 은 Device 범주안에 속해있다.
    {
        public void Work()  // Cellphon class 의 메서드 정의
        {
            Console.WriteLine("Phone is working");
            Console.ReadLine();
        }
    }

    class Laptop : IDevice  // Laptop 은 Device 범주안에 속해있다. 
    {
        public void Work()  // Laptop class 의 메서드 정의
        {
            Console.WriteLine("Laptop is working");
            Console.ReadLine();
        }
    }

    class Working  //  작동 class 생성 
    {
        public void Work(IDevice cellphone, IDevice laptop)  //   Working 클래스의 Work이라는 메서드를 정의 => Device 인터페이스에서 호출.매개변수 지정
        {
            Console.Write("휴대폰 : ");
            cellphone.Work();      // Device 라는 인터페이스의 메서드를 호출
            Console.WriteLine();
            Console.Write("노트북 : ");
            laptop.Work();         // Device 라는 인터페이스의 메서드를 호출
        }
    }

}
