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
			Console.WriteLine(IDsOfSongs(90, new List<int> { 1, 10, 25, 35, 60 }));
			Console.ReadLine();
		}

		public static List<int> IDsOfSongs(int rideDuration, List<int> songDurations)
		{
			int sumOfPairs = rideDuration - 30;
			List<SongPair> foundedPairs = new List<SongPair>();
			for (int i = 0; i < songDurations.Count; i++)
			{
				int currSongDuration = songDurations[i];
				var tempList = new List<int>(songDurations);
				tempList.RemoveAt(i);
				int pairId = Array.BinarySearch(tempList.ToArray(), (sumOfPairs - currSongDuration));
				if (pairId > 0 && pairId < songDurations.Count)
				{
					foundedPairs.Add(new SongPair
					{
						SongId1 = i,
						SongDuration1 = currSongDuration,
						SongId2 = pairId >= i ? pairId + 1 : pairId,
						SongDuration2 = songDurations[pairId >= i ? pairId + 1 : pairId]
					});
				}
			}
			if (foundedPairs.Count > 0)
			{
				int max = foundedPairs[0].SongDuration1 > foundedPairs[0].SongDuration2 ?
					foundedPairs[0].SongDuration1 : foundedPairs[0].SongDuration2;
				for (int i = 1; i < foundedPairs.Count; i++)
				{
					if (foundedPairs[i].SongDuration1 > max) max = foundedPairs[i].SongDuration1;
					if (foundedPairs[i].SongDuration2 > max) max = foundedPairs[i].SongDuration2;
				}
				var selectedPair = foundedPairs.Where(f => f.SongDuration1 == max ||
									f.SongDuration2 == max).First();
				return new List<int> { selectedPair.SongId1, selectedPair.SongId2 };
			}
			return new List<int>();
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
