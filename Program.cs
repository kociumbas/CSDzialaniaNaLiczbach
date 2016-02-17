using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7DzialaniaNaLiczbach
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, suma=0, roznica=0, iloczyn=0, iloraz=0;
            Console.WriteLine("Program sumę, różnicę, iloczyn oraz iloraz podanych liczb x i y z dokładnością do dwóch miejsc po przecinku");
            Console.Write("Podaj liczbę x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wyniki działań wynoszą:");
            Console.Write("Suma podanych liczb wynosi {0} + {1} = ", x, y);
            suma = x + y;
            Console.WriteLine("{0:##.##}", suma);
            Console.Write("Różnica podanych liczb wynosi {0} - {1} = ", x, y);
            roznica = x - y;
            Console.WriteLine("{0:##.##}", roznica);
            Console.Write("Iloczyn podanych liczb wynosi {0} * {1} = ", x, y);
            iloczyn = x * y;
            Console.WriteLine("{0:##.##}", iloczyn);
            Console.Write("Iloraz podanych liczb wynosi {0} / {1} = ", x, y);
            iloraz = x / y;
            Console.WriteLine("{0:##.##}", iloraz);
            Console.ReadLine();
        }
    }
}
