using EO.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaColaa
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			Random ale = new Random();
			int estado = 0;
			int llegada = 2 + ale.Next(0, 2);
			int salida = -1;
			int cantAtendidas = 0;
			Program cola = new Program();
			for (int minuto = 0; minuto < 600; minuto++)
			{
				if (llegada == minuto)
				{
					if (estado == 0)
					{
						estado = 1;
						salida = minuto + 2 + ale.Next(0, 3);
					}
					else
					{
						cola.Insertar(minuto);
					}
					llegada = minuto + 2 + ale.Next(0, 2);
				}
				if (salida == minuto)
				{
					estado = 0;
					cantAtendidas++;
					if (!cola.Vacia())
					{
						cola.Extraer();
						estado = 1;
						salida = minuto + 2 + ale.Next(0, 3);
					}
				}
			}

			label2.Text = "Atendidos: " + cantAtendidas.ToString();
			label3.Text = "En cola: " + cola.Cantidad().ToString();
			label4.Text = "Minuto llegada: " + cola.Extraer().ToString();

		}

	}
}

