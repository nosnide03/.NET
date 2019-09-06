using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Figura> lista = new List<Figura>() {
				new Triangulo(),
				new Rectangulo(),
				new Triangulo(),
				new Rectangulo(),
				new Rombo()
			};

			Console.WriteLine("--------------------CUADRADO---------------------");
			ObtenerFigura(lista, typeof(Cuadrado));
			Console.WriteLine("--------------------TRIANGULO--------------------");
			ObtenerFigura(lista, typeof(Triangulo));
			Console.ReadLine();
		}

		private static void ObtenerFigura(List<Figura> lista, Type type)
		{
			lista.Where(x => x.GetType().Equals(type) || x.GetType().BaseType.Equals(type)).ToList().ForEach(r =>
			{
				r.Pintar();
			});
		}
	}
}
