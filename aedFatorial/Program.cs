using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aedFatorial
{
	class Program
	{
		public static int fatorial(int n)
		{
			if (n == 1)
			{
				return 1;
			}

			return n * fatorial(n - 1);
		}


		static void Main(string[] args)
		{
			int n;
			string entrada;

			Console.Write("Escolha um numero para calcular fatorial: ");
			entrada = Console.ReadLine();
			n = Convert.ToInt32(entrada);

			Console.Write("Fatorial de {0} é: {1} ", entrada, fatorial(n));

			Console.ReadLine();
		}
	}
}
