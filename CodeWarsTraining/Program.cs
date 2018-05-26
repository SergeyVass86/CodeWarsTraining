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
			Console.WriteLine(validBraces("()"));
			Console.WriteLine(validBraces("[(])"));
			Console.WriteLine(validBraces("(){}[]"));
			Console.WriteLine(validBraces("([{}])"));
			Console.WriteLine(validBraces("[({})](]"));
			Console.WriteLine(validBraces("(}"));
			Console.WriteLine(validBraces("(({{[[]]}}))"));
			Console.ReadLine();
		}

		private static IDictionary<char, char> _bracesMap = new Dictionary<char, char>()
		{
			{'(', ')'},
			{'{', '}'},
			{'[', ']'}
		};

		public static bool validBraces(String braces)
		{
			Stack<char> stack = new Stack<char>();
			foreach (var c in braces)
			{
				if (stack.Count > 0 && _bracesMap.ContainsKey(stack.Peek()) && _bracesMap[stack.Peek()] == c) stack.Pop();
				else stack.Push(c);
			}
			return stack.Count == 0;
		}
	}
}
