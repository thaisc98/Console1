using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
	class Program
	{
		private int[,] matriz;


		public void Carga()
		{
			String linea;
			matriz = new int[2, 5];

			for(int x =0; x<2; x++)
			{
				for(int y=0; y < 5; y++)
				{
					Console.Write("Ingrese posicion [" + (x + 1) + "," + (y + 1) + "]: ");
					linea = Console.ReadLine();
					matriz[x, y] = int.Parse(linea);
				}
			}
		}

		public void Imprimir()
		{
			for(int x = 0; x<2; x++)
			{
				for (int y =0; y<5; y++)
				{
					
					Console.Write(" " + matriz[x, y] + " " );
				}
				Console.Write("\n");
			}
			Console.WriteLine();
			Console.ReadKey();
		}

		static void Main(string[] args)
		{
			Program p = new Program();
			p.Carga();
			p.Imprimir();
			
		}
	}
}
