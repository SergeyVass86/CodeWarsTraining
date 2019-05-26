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
			int counter = 0;
			Parallel.For(0, 100, i => counter++);
			Console.WriteLine(counter);
			//Console.WriteLine(binaryArrayToNumber(new int[] { 0, 0, 0, 0 }));
			//Console.WriteLine(binaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
			//Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
			//Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
			//Console.WriteLine(binaryArrayToNumber(new int[] { 1, 0, 1, 1 }));
			Console.ReadLine();
		}

		public static int binaryArrayToNumber(int[] BinaryArray)
		{
			int i = 0;
			return BinaryArray.Reverse().Sum(f => (int)(Math.Pow(2, i++)) * f);
		}
	}
}
