using System;
using System.Security.Cryptography.X509Certificates;


namespace ListaAscDesc
{
	class ListaAD
	{
		 class Nodo{
			public int num;
			public Nodo sig;

			public Nodo(int numero){
				num = numero;
				sig = null;
			}
		}

		private Nodo raiz;

		public ListaAD(){
			raiz = null;
		}

		public void Ascendente(int x){
			Nodo nodo = new Nodo(x);
			Nodo reco1;
			Nodo reco2;

			if (raiz == null){
				raiz = nodo;
				nodo.sig = null;
			}
			else{
				reco1 = raiz;
				while (reco1 != null){
					reco2 = reco1.sig;
					if (nodo.num <= reco1.num){
						nodo.sig = raiz;
						raiz = nodo;
						break;
					}
					else if (nodo.num > reco1.num && reco2 == null){
						reco1.sig = nodo;
						nodo.sig = null;
						break;
					}
					else if (reco1.num < nodo.num && reco2.num >= nodo.num){
						reco1.sig = nodo;
						nodo.sig = reco2;
						break;
					}
					else {
						reco1 = reco1.sig;
					}

				}
			}
		}

		public void Descendente(int x){
			Nodo nodo = new Nodo(x);
			Nodo reco1;
			Nodo reco2;

			if (raiz == null) {
				raiz = nodo;
				nodo.sig = null;
			}
			else{
				reco1 = raiz;
				while (reco1 != null){
					reco2 = reco1.sig;
					if (nodo.num >= reco1.num){
						nodo.sig = raiz;
						raiz = nodo;
						break;
					}
					else if (nodo.num < reco1.num && reco2 == null){
						reco1.sig = nodo;
						nodo.sig = null;
						break;
					}
					else if (reco1.num > nodo.num && reco2.num <= nodo.num){
						reco1.sig = nodo;
						nodo.sig = reco2;
						break;
					}
					else
					{
						reco1 = reco1.sig;
					}

				}
			}
		}
	

		public void mostrarAscendente() {
			Nodo record;
			record = raiz;
			while (record != null){
				Console.WriteLine(record.num + "  ");
				record = record.sig;
			}
		}

		public void mostrarDescendente(){
			Nodo record;
			record = raiz;
			while (record != null){
				Console.WriteLine(record.num + "  ");
				record = record.sig;
			}
		}



		static void Main(string[] args) {

			int nom;
			int cantidad;
			
			Console.WriteLine("=== || FINAL DE ESTRUCTURA DE DATOS || ===\n");
			Console.WriteLine("=== Orden de numeros de forma descendente y ascendente ===\n");

			Console.Write("== Cantidad de numeros que desean ser ordenados: ");
			cantidad = int.Parse(Console.ReadLine());
			int[] n = new int[cantidad];

			Console.WriteLine(" ");
			ListaAD a = new ListaAD();
			ListaAD d = new ListaAD();

			for (int z = 0; z < n.Length; z++)
			{
				
				Console.Write("Ingrese el numero ["+(z + 1)+"]: ");
				nom = int.Parse(Console.ReadLine());
				n[z] = nom;

				a.Ascendente(nom);
				d.Descendente(nom);
			}

			Console.WriteLine(" ");
			Console.WriteLine("== || Orden ascentente || ==");
			a.mostrarAscendente();

			Console.WriteLine(" ");
			Console.WriteLine("== || Orden descendente || ==");
			d.mostrarDescendente();

			Console.WriteLine("== Clic enter para terminar... ===");
			Console.ReadKey();
			
		}
	}
}