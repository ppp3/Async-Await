using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = foo();
            for (int i=0; i<10; i++){
                Console.WriteLine($"Sleeping in Main {i}");
                Thread.Sleep(1000);
            }

            task.Wait();
        }

        
        public static async Task foo()
        {
            
            int grosseZahl = 2000;
            int[] a=await Task.Run( ()  => myFunction(grosseZahl)   );
            Console.WriteLine(a[0]);
        }

        public static int[] myFunction(int a)
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine($"Sleeping in myFunction {i}");
                Thread.Sleep(1000);
            }
            
            int[] result = new int [] { 1, 2 };
            return result;
        }
    }
}

