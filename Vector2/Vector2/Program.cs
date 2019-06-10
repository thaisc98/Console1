using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2
{
	public class Program
	{
		/* Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
		 * Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño.
		 * Sumar componente a componente
		 * */

		private int[] vector;
		private int[] vector2;
		private int[] sVector;

		public void Cargar()
		{
			String linea;
			vector = new int[4];
			vector2 = new int[4];
			for (int x = 0; x < 4; x++)
			{
				Console.Write("Ingrese los elementos del vector 1: ");
				linea = Console.ReadLine();
				vector[x] = int.Parse(linea);
				
			}
			Console.WriteLine();
			for (int x = 0; x < 4; x++)
			{
				Console.Write("Ingrese los elementos del vector 2: ");
				linea = Console.ReadLine();
				vector2[x] = int.Parse(linea);
			}
		}

		public void SumaV()
		{
			int suma = 0;
			sVector = new int[4];
			for(int x=0; x< 4; x++)
			{
				sVector[x] = vector[x] + vector2[x];
				suma = suma + sVector[x];
			}
			Console.Write("La suma de los elementos es: " + suma);
		}

		static void Main(string[] args)
		{
			Program p = new Program();
			p.Cargar();
			p.SumaV();
			Console.ReadKey();
		}
	}
}
