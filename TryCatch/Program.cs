using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
       /* static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a / 0);
        }*/


        static void Main(string[] args)
        {

            try
            {
                int[] array = new int[3] { 1, 2, 3, };
                for(int i = 0; i < 5; i++)
                {                               
                    Console.WriteLine(array[i]);

                }

               /* int a = 10;
                string b = "bbb";
                Console.WriteLine(a * b);
*/
            }


            catch (DivideByZeroException e)
            {
                Console.WriteLine("예외 1");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("예외2");
                Console.WriteLine(e.Message);
                throw new MyException();
                Console.ReadLine();
            }

            finally
            {
                Console.WriteLine("예외가 발생되었습니다.");
            }
        }
    }
}
