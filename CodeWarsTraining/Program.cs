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
			Console.WriteLine(MinimumNumber(new int[] { 3, 1, 2 }));
			Console.WriteLine(MinimumNumber(new int[] { 5, 2 }));
			Console.WriteLine(MinimumNumber(new int[] { 1, 1, 1 }));
			Console.WriteLine(MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
			Console.WriteLine(MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
			Console.ReadLine();
		}

		public static int MinimumNumber(int[] numbers)
		{
			int result = 0;
			var sum = numbers.Sum();
			bool found = false;
			while(!found)
			{
				if(IsPrime(sum))
				{
					found = true;
				}
				else
				{
					sum++;
					result++;
				}
			}
			return result;
		}

		public static bool IsPrime(int num)
		{
			if (num == 1) return false;
			if (num == 2) return true;
			if (num % 2 == 0) return false;

			var boundary = (int)Math.Floor(Math.Sqrt(num));

			for (int i = 3; i <= boundary; i += 2)
			{
				if (num % i == 0) return false;
			}

			return true;
		}
	}
}
