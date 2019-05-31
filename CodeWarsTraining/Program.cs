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
			//Console.WriteLine(IsBalanced("(Sensei says yes!)", "()"));
			//Console.WriteLine(IsBalanced("(Sensei says no!", "()"));
			//Console.WriteLine(IsBalanced("(Sensei [says] yes!)", "()[]"));
			//Console.WriteLine(IsBalanced("(Sensei [says) no!]", "()[]"));
			//Console.WriteLine(IsBalanced("Sensei says -yes-!", "--"));
			//Console.WriteLine(IsBalanced("Sensei -says no!", "--"));
			//Console.WriteLine(IsBalanced("Hello Mother can you hear me?)[Monkeys, in my pockets!!]", "()[]"));
			var optimalList = optimalUtilization(7, new List<List<int>> { new List<int> { 1, 4 }, new List<int> { 2, 1 }, new List<int> { 3, 3 }, new List<int> { 4, 3 } }, new List<List<int>> { new List<int> { 1, 4 } });
			foreach(var item in optimalList)
			{
				Console.WriteLine(string.Format("fapp: {0} bapp: {1}", item[0], item[1]));
			}
			Console.ReadLine();
		}

		public static List<List<int>> optimalUtilization(int deviceCapacity,
											 List<List<int>> foregroundAppList,
											 List<List<int>> backgroundAppList)
		{
			List<List<int>> result = new List<List<int>>();
			var sortedFapp = foregroundAppList.Where(f => f[1] <= deviceCapacity).OrderBy(f => f[1]).ToList();
			var sortedBapp = backgroundAppList.Where(f => f[1] <= deviceCapacity).OrderBy(f => f[1]).ToList();
			int max = 0;
			foreach (var fapp in sortedFapp)
			{
				var remainingBapps = sortedBapp.Where(f => f[1] <= deviceCapacity - fapp[1]).ToList();
				if (remainingBapps.Count > 0)
				{
					if (fapp[1] + remainingBapps.Last()[1] >= max)
					{
						if (fapp[1] + remainingBapps.Last()[1] > max)
						{
							max = fapp[1] + remainingBapps.Last()[1];
							if (result.Count > 0)
							{
								var removeItems = result.Where(f => f[0] + f[1] < max).ToList();
								result.Clear();
							}
						}
						foreach (var maxItem in remainingBapps.Where(f => f[1] == remainingBapps.Last()[1]))
						{
							result.Add(new List<int> { fapp[0], maxItem[0] });
						}
					}
				}
			}
			return result;
		}

		private class SongPair
		{
			public int SongId1 { get; set; }
			public int SongDuration1 { get; set; }
			public int SongId2 { get; set; }
			public int SongDuration2 { get; set; }
		}
	}
}
