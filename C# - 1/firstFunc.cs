using System;

namespace ProjectTest
{
	class Main {
		public static void Main (string[] args) {
			int a = 76, b = 0;
			switch (a) {
				case 1:
					b=45;
					break;
				case 76:
					b=2;
					Console.Write ("Hi!");
					break;
				case 56:
					b=65;
					break;
				default:
					b=1;
					Console.Write ("Else!");
					break;
			}
			Console.WriteLine (b);
		}
	}
}