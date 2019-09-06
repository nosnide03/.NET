using System;

namespace Entity
{
	public class Cuadrado : Figura
	{
		public override void Pintar()
		{
			Console.WriteLine(this.GetType().Name);
		}
	}
}
