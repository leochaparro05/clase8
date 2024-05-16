using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int num;
            num = Convert.ToInt16(Console.ReadLine());
            int cont0 = 0;
            int b = num / 2;
            for (int i = 2; i <= b; i++)
            {
                if (num % i != 0)
                    cont0++;
            }
            if (cont0 == 0)
                Console.WriteLine("ES PRIMO");
            else Console.WriteLine("NO ES PRIMO");
            Console.ReadKey();
        }
       
    }
}
