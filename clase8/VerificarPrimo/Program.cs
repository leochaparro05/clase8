using System;

namespace VerificarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;

            for (int i = 2; i <= num / 2; i++)
            {

                if (num % i == 0)
                {

                    divisor++;
 
                   
                }
            }

            if (divisor == 0)
                Console.WriteLine("El número es PRIMO");
            else
                Console.WriteLine("El número NO es PRIMO");

            Console.ReadKey();
        }
    }
}