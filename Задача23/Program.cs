using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Задача23
{ /*
   Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
   
   */
    class Program
    {
        static void Method(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(100);
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
        
        static async void FactorialAsync()

        {
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Метод FactorialAsync начал работу"); 
            await Task.Run(() => Method(n));                
            Console.WriteLine("Метод  FactorialAsync закончил работу");
        }

        static void Main(string[] args)
        {
            FactorialAsync();   

            

            Console.ReadKey();
        }
    }
}
