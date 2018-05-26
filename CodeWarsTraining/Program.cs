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

		public static bool validBraces(String braces)
		{
			Dictionary<char, int> bracesRanks = new Dictionary<char, int>();
			Dictionary<char, int> bracesCount = new Dictionary<char, int>();
			foreach (var c in braces)
			{
				switch(c)
				{
					case ')':
						if (bracesRanks.ContainsKey('(') && bracesRanks.Max(f => f.Value) == bracesRanks['('])
							bracesCount['(']--;
						else return false;
						if (bracesCount['('] == 0)
						{
							bracesRanks.Remove('(');
							bracesCount.Remove('(');
						}
						break;
					case '}':
						if (bracesRanks.ContainsKey('{') && bracesRanks.Max(f => f.Value) == bracesRanks['{'])
							bracesCount['{']--;
						else return false;
						if (bracesCount['{'] == 0)
						{
							bracesRanks.Remove('{');
							bracesCount.Remove('{');
						}
						break;
					case ']':
						if (bracesRanks.ContainsKey('[') && bracesRanks.Max(f => f.Value) == bracesRanks['['])
							bracesCount['[']--;
						else return false;
						if (bracesCount['['] == 0)
						{
							bracesRanks.Remove('[');
							bracesCount.Remove('[');
						}
						break;
					default:
						if (!bracesRanks.ContainsKey(c))
						{
							bracesRanks.Add(c, bracesRanks.Any() ? bracesRanks.Max(f => f.Value) + 1 : 1);
							bracesCount.Add(c, 1);
						}
						else
						{
							bracesCount[c]++;
						}
						break;
				}
			}
			return bracesCount.All(f => f.Value == 0);
		}
	}
}
