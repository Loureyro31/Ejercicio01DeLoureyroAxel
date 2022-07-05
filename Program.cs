using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01DeLoureyroAxel
{
    class Program
    {
        static void Main(string[] args)
        {
			double dolar;
			double euros;
			double pesos;
			Console.WriteLine("ingrese la cantidad de pesos que posee");
			pesos = Double.Parse(Console.ReadLine());
			dolar = pesos / 230;
			Console.WriteLine("con " + pesos + " pesos puede comprar " + dolar + " dolares");
			euros = dolar * 1.17;
			Console.WriteLine("y con " + dolar + " dolares puede comprar " + euros + " euros");
		}
    }
}
