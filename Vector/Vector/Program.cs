using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
	class Program
	{
		private int[] sueldos;

		public void Cargar()
		{
			sueldos = new int[5];
			for (int x = 0; x < 5; x++)
			{
				Console.Write("Ingrese valor de la componente:");
				String linea;
				linea = Console.ReadLine();
				sueldos[x] = int.Parse(linea);
			}
		}
		public void Imprimir()
		{
			for (int x = 0; x < 5; x++)
			{
				Console.WriteLine(sueldos[x]);
			}
			Console.ReadKey();
		}


		static void Main(string[] args)
		{
			Program p = new Program();
			p.Cargar();
			p.Imprimir();
		}
		
	}
}
