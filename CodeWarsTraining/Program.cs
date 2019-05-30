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
			Console.WriteLine(IsBalanced("(Sensei says yes!)", "()"));
			Console.WriteLine(IsBalanced("(Sensei says no!", "()"));
			Console.WriteLine(IsBalanced("(Sensei [says] yes!)", "()[]"));
			Console.WriteLine(IsBalanced("(Sensei [says) no!]", "()[]"));
			Console.WriteLine(IsBalanced("Sensei says -yes-!", "--"));
			Console.WriteLine(IsBalanced("Sensei -says no!", "--"));
			Console.WriteLine(IsBalanced("Hello Mother can you hear me?)[Monkeys, in my pockets!!]", "()[]"));
			Console.WriteLine(IsBalanced("(Hello Mother can you hear me?))", "()"));
			Console.ReadLine();
		}

		public static bool IsBalanced(string s, string caps)
		{
			IDictionary<char, char> _bracesMap = new Dictionary<char, char>();

			var temp = caps;
			while(temp != null && temp.Length > 0)
			{
				var chars = temp.Substring(0, 2).Select(c => c);
				_bracesMap.Add(chars.First(), chars.Last());
				temp = temp.Substring(2);
			}
			Stack<char> stack = new Stack<char>();
			foreach (var c in s)
			{
				if (stack.Count > 0 && _bracesMap.ContainsKey(stack.Peek()) && _bracesMap[stack.Peek()] == c) stack.Pop();
				else if(_bracesMap.ContainsKey(c) || _bracesMap.Any(f => f.Value == c)) stack.Push(c);
			}
			return stack.Count == 0;
		}
	}
}
