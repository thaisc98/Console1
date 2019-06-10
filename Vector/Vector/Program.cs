using System;


namespace Vector
{
	class Program
	{
		private int[] vector;

		public void Cargar()
		{
			String linea;
			vector = new int[8];
			for (int x = 0; x < 8; x++)
			{
				Console.Write("Ingrese los elementos: ");
				linea = Console.ReadLine();
				vector[x] = int.Parse(linea);
			}
		}

		public void CalculoElementos()
		{
			int suma = 0;
			int sMayTS = 0; //36
			int sMayCT = 0; //50
			for(int x=0; x<8; x++)
			{
				suma = suma + vector[x];
				if(vector[x] > 36)
				{
					sMayTS = sMayTS + vector[x];
				}
				if(vector[x] > 50)
				{
					sMayCT++;
				}
			}
			Console.Write("Suma de los 8 elementos es:" + suma);
			Console.WriteLine();
			Console.Write("Suma de los 8 elementos mayores de 36 es:" + sMayTS);
			Console.WriteLine();
			Console.Write("Cantidad de los elementos mayores de 50 es:" + sMayCT);
		}

		static void Main(string[] args)
		{
			Program p = new Program();
			p.Cargar();
			p.CalculoElementos();
			Console.ReadKey();
		}
		
	}
}
