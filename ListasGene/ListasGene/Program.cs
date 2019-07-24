using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaGene
{
	class ListaGenericaDoble
	{
		class Nodo {
			public int info;
			public Nodo ant, sig;
		}

		private Nodo raiz;

		public ListaGenericaDoble() {
			raiz = null;
		}

		void InsertarPrimero(int x) {
			Nodo nuevo = new Nodo();
			nuevo.info = x;
			nuevo.sig = raiz;
			if (raiz != null)
				raiz.ant = nuevo;
			raiz = nuevo;
		}

		public void InsertarUtlimo(int x) {
			Nodo nuevo = new Nodo();
			nuevo.info = x;
			if (raiz == null)
				raiz = nuevo;
			else {
				Nodo reco = raiz;
				while (reco.sig != null) {
					reco = reco.sig;
				}
				reco.sig = nuevo;
				nuevo.ant = reco;
			}
		}

		public void InsertarSegundo(int x){
			if (raiz != null){
				Nodo nuevo = new Nodo();
				nuevo.info = x;
				if (raiz.sig == null) {
					//Hay un solo nodo.
					raiz.sig = nuevo;
					nuevo.ant = raiz;
				}
				else {
					Nodo tercero = raiz.sig;
					nuevo.sig = tercero;
					tercero.ant = nuevo;
					raiz.sig = nuevo;
					nuevo.ant = raiz;
				}
			}
		}

		public void InsertarAnteUltimo(int x) {
			if (raiz != null) {
				Nodo nuevo = new Nodo();
				nuevo.info = x;
				if (raiz.sig == null) {
					//Hay un solo nodo.
					nuevo.sig = raiz;
					raiz = nuevo;
				}
				else {
					Nodo reco = raiz;
					while (reco.sig != null) {
						reco = reco.sig;
					}
					Nodo anterior = reco.ant;
					nuevo.sig = reco;
					nuevo.ant = anterior;
					anterior.sig = nuevo;
					reco.ant = nuevo;
				}
			}
		}

		public void BorrarPrimero() {
			if (raiz != null) {
				raiz = raiz.sig;
			}
		}

		public void BorrarSegundo() {
			if (raiz != null) {
				if (raiz.sig != null) {
					Nodo tercero = raiz.sig;
					tercero = tercero.sig;
					raiz.sig = tercero;
					if (tercero != null)
						tercero.ant = raiz;
				}
			}
		}

		public void BorrarUltimo() {
			if (raiz != null) {
				if (raiz.sig == null) {
					raiz = null;
				}
				else {
					Nodo reco = raiz;
					while (reco.sig != null) {
						reco = reco.sig;
					}
					reco = reco.ant;
					reco.sig = null;
				}
			}

		}
		public void Imprimir() {
			Nodo reco = raiz;
			while (reco != null) {
				Console.Write(reco.info + "-");
				reco = reco.sig;
			}
			Console.WriteLine();
		}

		public void BorrarMayor() {
			if (raiz != null) {
				Nodo reco = raiz;
				int may = raiz.info;
				while (reco != null) {
					if (reco.info > may) {
						may = reco.info;
					}
					reco = reco.sig;
				}
				reco = raiz;
				while (reco != null) {
					if (reco.info == may) {

						if (reco == raiz){
							raiz = raiz.sig;
							if (raiz != null)
								raiz.ant = null;
							reco = raiz;
						}
						else{
							Nodo atras = reco.ant;
							atras.sig = reco.sig;
							reco = reco.sig;
							if (reco != null)
								reco.ant = atras;
						}
					}
					else{
						reco = reco.sig;
					}
				}
			}
		}

		static void Main(string[] args) {
			ListaGenericaDoble lg = new ListaGenericaDoble();
			lg.InsertarPrimero(11);
			lg.InsertarPrimero(20);
			lg.InsertarPrimero(90);
			lg.InsertarPrimero(49);
			lg.Imprimir();
			Console.WriteLine("Insertamos un nodo al final: ");
			lg.InsertarUtlimo(120);
			lg.Imprimir();
			Console.WriteLine("Insertamos un nodo en la segunda posición:");
			lg.InsertarSegundo(29);
			lg.Imprimir();
			Console.WriteLine("Insertamos un nodo en la anteultima posición :");
			lg.InsertarAnteUltimo(100);
			lg.Imprimir();
			Console.WriteLine("Borramos el primer nodo de la lista:");
			lg.BorrarPrimero();
			lg.Imprimir();
			Console.WriteLine("Borramos el segundo nodo de la lista:");
			lg.BorrarSegundo();
			lg.Imprimir();
			Console.WriteLine("Borramos el ultimo nodo de la lista :");
			lg.BorrarUltimo();
			lg.Imprimir();
			Console.WriteLine("Borramos el mayor de la lista: ");
			lg.BorrarMayor();
			lg.Imprimir();
			Console.ReadKey();
		}
	}
}
