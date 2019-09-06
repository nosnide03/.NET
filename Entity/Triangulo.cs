using System;

namespace Entity
{
	public class Triangulo : Figura
	{
		public override void Pintar()
		{
			Console.WriteLine(this.GetType().Name);
		}
	}
}
