using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16MAYO2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;
            Console.WriteLine("Digite el primer numero");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            N2 = Convert.ToInt32(Console.ReadLine());
            if (N1 > N2)
            {
                Console.WriteLine("el numero mayor es " + (N1));
            }
            else if (N2 > N1)
            {
                Console.WriteLine("el numero mayor es " + (N2));
            }
            else
            {
                Console.WriteLine("los numeros son iguales y su valor es " +N1);
            }
                Console.ReadKey();
        }
    }
}
