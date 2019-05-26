using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining
{
	class Program
	{
		private const string LOWER = "abcdefghijklmnopqrstuvwxyz";
		private const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		static void Main(string[] args)
		{
			Console.WriteLine(Rot13("test"));
			Console.WriteLine(Rot13("Test"));
			Console.ReadLine();
		}

		public static string Rot13(string message)
		{
			return String.Join("", message
			  .Select(c =>
			  {
				  var chars = Char.IsUpper(c) ? UPPER : LOWER;
				  var idx = chars.IndexOf(c);
				  return idx == -1 ?
					c :
					chars[(idx + 13) % chars.Length];
			  }));
		}
	}
}
