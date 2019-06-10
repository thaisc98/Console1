using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3
{
	class Program
	{
	    private int[] cursoA;
		private int[] cursoB;
		private int[] vecSuma;

			public void Cargar()
			{
				String linea;
				cursoA = new int[6];
				cursoB = new int[6];
				for (int x = 0; x < 6; x++)
				{
					Console.Write(" Ingrese nota #" + (x + 1) + " del curso A:");
					linea = Console.ReadLine();
					cursoA[x] = int.Parse(linea);

				}
				Console.WriteLine();
				for (int x = 0; x < 6; x++)
				{
					Console.Write(" Ingrese nota #" + (x + 1) + " del curso B:");
					linea = Console.ReadLine();
					cursoB[x] = int.Parse(linea);
				}
			}

			public void Promedio()
			{
				int pCA = 0;
				int pCB = 0;

				for (int x = 0; x < 6; x++)
				{
					pCA = pCA + cursoA[x];
					pCB = pCB + cursoB[x];
				}

				pCA = pCA / 6;
				pCB = pCB / 6;
				if (pCA > pCB)
				{
					Console.Write("El  curso A tiene el promedio mayor");
					Console.WriteLine();
				}
				if (pCA < pCB)
				{
					Console.Write("El  curso B tiene el promedio mayor");
					Console.WriteLine();
				}
				Console.Write("El promedio del curso A es:" + pCA);
				Console.WriteLine();
				Console.Write("El promedio del curso B es:" + pCB);
			}

			static void Main(string[] args)
			{
				Program p = new Program();
				p.Cargar();
				p.Promedio();
				Console.ReadKey();
			}
		}
	
}
