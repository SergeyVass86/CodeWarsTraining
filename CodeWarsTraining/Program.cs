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
			Console.WriteLine(MaxMultiply(2, 7));
			Console.WriteLine(MaxMultiply(3, 10));
			Console.WriteLine(MaxMultiply(7, 17));
			Console.WriteLine(MaxMultiply(10, 50));
			Console.WriteLine(MaxMultiply(37, 200));
			Console.WriteLine(MaxMultiply(7, 100));
			Console.ReadLine();
		}

        public static int MaxMultiply(int divisor, int bound)
        {
			return bound / divisor * divisor;
        }
    }
}
