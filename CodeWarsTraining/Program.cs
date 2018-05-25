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
			Console.WriteLine(Find(new int[] { 2, 6, 8, -10, 3 }));
			Console.WriteLine(Find(new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }));
			Console.WriteLine(Find(new int[] { int.MaxValue, 0, 1 }));
			Console.ReadLine();
		}

		public static int Find(int[] integers)
		{
			return (integers.Count(f => f % 2 == 0) > 1) ? integers.SingleOrDefault(f => f % 2 > 0) : integers.SingleOrDefault(f => f % 2 == 0);
		}
	}
}
