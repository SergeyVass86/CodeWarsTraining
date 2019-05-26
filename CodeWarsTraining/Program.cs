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
			Console.WriteLine(Rot13("test"));
			Console.WriteLine(Rot13("Test"));
			Console.ReadLine();
		}

		public static string Rot13(string message)
		{
			List<char> charList = message
				.Select(f => 
				{
					if((int)f >= 65 && (int)f <= 90)
					{
						int res = (int)f + 13;
						if(res > 90)
						{
							res = 64 + (res - 90);
						}
						return (char)res;
					}
					else if ((int)f >= 97 && (int)f <= 122)
					{
						int res = (int)f + 13;
						if (res > 122)
						{
							res = 96 + (res - 122);
						}
						return (char)res;
					}
					return f;
				}).ToList();
			var sb = new StringBuilder();
			foreach(var c in charList)
			{
				sb.Append(c.ToString());
			}
			return sb.ToString();
		}
	}
}
