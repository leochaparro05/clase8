using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generar_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("solicitar desde y hasta ");
            int desde = Convert.ToInt32(Console.ReadLine());
            int hasta = Convert.ToInt32(Console.ReadLine());

            for (int i = desde; i < hasta; i++)
            {
                int num = i;
                int divisor = 0;
         
                for (int n = 2; i <= num / 2; i++)
                {

                    if (num % n == 0)
                    {

                        divisor++;


                    }
                    if (divisor == 0)
                        Console.WriteLine($"{num}");
                }
              

                
             
            }
        }
    }
}
