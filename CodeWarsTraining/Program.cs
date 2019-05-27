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
			Console.WriteLine(GetReadableTime(0));
			Console.WriteLine(GetReadableTime(5));
			Console.WriteLine(GetReadableTime(60));
			Console.WriteLine(GetReadableTime(86399));
			Console.WriteLine(GetReadableTime(359999));
			Console.ReadLine();
		}

		public static string GetReadableTime(int seconds)
		{
			if (seconds > 359999) return "";

			TimeSpan t = TimeSpan.FromSeconds(seconds);

			return string.Format("{0:D2}:{1:D2}:{2:D2}",
							t.Hours + (t.Days > 0 ? t.Days * 24 : 0),
							t.Minutes,
							t.Seconds);
		}
	}
}
