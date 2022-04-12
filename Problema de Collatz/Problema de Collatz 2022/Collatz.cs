using System;

namespace Application
{
	public class Collatz
	{
		public static void Main ()
		{
			System.Console.WriteLine ("insira um numero:");
			int num = int.Parse (System.Console.ReadLine ());
			int contador = 0;
			while (num > 1) {
				
			
				contador++;
				if (num % 2 == 0) {
					num = num / 2;
					System.Console.WriteLine (num);
				} else {

					num = (num * 3) + 1;
				}
				Console.WriteLine ("Numero de voltas {0}. Atual numero da conjectura {1}", contador, num);
			}

		}
	}
}

