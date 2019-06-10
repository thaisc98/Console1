using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector4
{
	class Program
	{
		String linea;
		private int[] vector;

		public void Cargar()
		{
			vector = new int[10];
			for(int x=0; x < 10; x++)
			{
				Console.Write("Ingrese los elementos: ");
				linea = Console.ReadLine();		
				vector[x] = int.Parse(linea);
			}
		}

		public void Comprobador()
		{
			int orden = 1;
			for(int x=0;x<9; x++)
			{
				if(vector[x + 1] < vector[x])
				{
					orden = 0;
				}
			}
			if(orden == 1)
			{
				Console.Write("Esta ordenado de menor a mayor");
				Console.WriteLine();
			}
			else
			{
				Console.Write("Esta ordenado de mayor a menor");
			}
		}


		static void Main(string[] args)
		{
			Program p = new Program();
			p.Cargar();
			p.Comprobador();
			Console.ReadKey();
		}
	}
}
