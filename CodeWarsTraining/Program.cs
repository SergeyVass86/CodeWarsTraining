using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(IsPrime(0));
			Console.WriteLine(IsPrime(1));
			Console.WriteLine(IsPrime(2));
			Console.ReadLine();
		}

		public static bool IsPrime(int n)
		{
			if (n <= 3) return n > 1;
			else if (n % 2 == 0 || n % 3 == 0) return false;
			var i = 5;
			while (i * i <= n)
			{
				if (n % i == 0 || n % (i + 2) == 0) return false;
				i += 6;
			}
			return true;
		}
	}
}
