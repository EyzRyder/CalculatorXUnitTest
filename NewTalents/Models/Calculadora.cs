using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents.Models
{
	public class Calculadora
	{
		private List<string> listaHistorico;
		public string dataAtual;
		public Calculadora (string data)
		{
			dataAtual = data;
			listaHistorico = new List<string>();
		}
		public int somar(int a, int b)
		{
			int res = a+b;
			listaHistorico.Insert(0, "Res: "+res);
			return res;
		}

		public int subtrair(int a, int b)
		{
			int res = a-b;
			listaHistorico.Insert(0, "Res: "+res);
			return res;
		}
		public int mutiplicar(int a, int b)
		{
			int res = a*b;
			listaHistorico.Insert(0, "Res: "+res);
			return res;
		}
		public float dividir(int a, int b)
		{
			float res = a/b;
			listaHistorico.Insert(0, "Res: "+res);
			return res;
		}

		public List<string> historico ()
		{

			listaHistorico.RemoveRange(3,listaHistorico.Count-3);
			return listaHistorico;

		}
	}
}
