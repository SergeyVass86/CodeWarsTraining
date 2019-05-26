using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining
{
	class Program
	{
		private const string firstLine = "qwertyuiop";
		private const string firstLineShift = "QWERTYUIOP";
		private const string secondLine = "asdfghjkl";
		private const string secondLineShift = "ASDFGHJKL";
		private const string thirdLine = "zxcvbnm,.";
		private const string thirdLineShift = "ZXCVBNM<>";

		static void Main(string[] args)
		{
			Console.WriteLine(Encrypt("A", 111));
			Console.WriteLine(Encrypt("Abc", 212));
			Console.WriteLine(Encrypt("Wave", 0));
			Console.WriteLine(Encrypt("Wave", 345));
			Console.WriteLine(Encrypt("Ball", 134));
			Console.WriteLine(Encrypt("Ball", 444));
			Console.WriteLine(Encrypt("This is a test.", 348));
			Console.WriteLine(Encrypt("Do the kata Kobayashi Maru Test. Endless fun and excitement when finding a solution.", 583));

			Console.WriteLine(Decrypt("S", 111));
			Console.WriteLine(Decrypt("Smb", 212));
			Console.WriteLine(Decrypt("Wave", 0));
			Console.WriteLine(Decrypt("Tg.y", 345));
			Console.WriteLine(Decrypt(">fdd", 134));
			Console.WriteLine(Decrypt(">gff", 444));
			Console.WriteLine(Decrypt("Iaqh qh g iyhi,", 348));
			Console.WriteLine(Decrypt("Sr pgi jlpl Jr,lqlage Zlow Piapc I.skiaa dw. l.s ibnepizi.p ugi. de.se.f l arkwper.c", 583));
			Console.ReadLine();
		}

		public static string Encrypt(string text, int key)
		{
			var keyStr = key.ToString("D3").Select(c => c).ToList();
			return String.Join("", text
			  .Select(c =>
			  {
				  bool isUpper = Char.IsUpper(c) || thirdLineShift.Contains(c);
				  int move = 0;
				  string chars = string.Empty;
				  if (isUpper)
				  {
					  if (firstLineShift.Contains(c))
					  {
						  move = int.Parse(keyStr[0].ToString());
						  chars = firstLineShift;
					  }
					  else if (secondLineShift.Contains(c))
					  {
						  move = int.Parse(keyStr[1].ToString());
						  chars = secondLineShift;
					  }
					  else if (thirdLineShift.Contains(c))
					  {
						  move = int.Parse(keyStr[2].ToString());
						  chars = thirdLineShift;
					  }
				  }
				  else
				  {
					  if (firstLine.Contains(c))
					  {
						  move = int.Parse(keyStr[0].ToString());
						  chars = firstLine;
					  }
					  else if (secondLine.Contains(c))
					  {
						  move = int.Parse(keyStr[1].ToString());
						  chars = secondLine;
					  }
					  else if (thirdLine.Contains(c))
					  {
						  move = int.Parse(keyStr[2].ToString());
						  chars = thirdLine;
					  }
				  }
				  var idx = chars.IndexOf(c);
				  return idx == -1 ?
					c :
					chars[(idx + move) % chars.Length];
			  }));
		}

		public static string Decrypt(string encryptedText, int key)
		{
			var keyStr = key.ToString("D3").Select(c => c).ToList();
			return String.Join("", encryptedText
			  .Select(c =>
			  {
				  bool isUpper = Char.IsUpper(c) || thirdLineShift.Contains(c);
				  int moveBack = 0;
				  string chars = string.Empty;
				  if (isUpper)
				  {
					  if (firstLineShift.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[0].ToString()) * -1;
						  chars = firstLineShift;
					  }
					  else if (secondLineShift.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[1].ToString()) * -1;
						  chars = secondLineShift;
					  }
					  else if (thirdLineShift.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[2].ToString()) * -1;
						  chars = thirdLineShift;
					  }
				  }
				  else
				  {
					  if (firstLine.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[0].ToString()) * -1;
						  chars = firstLine;
					  }
					  else if (secondLine.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[1].ToString()) * -1;
						  chars = secondLine;
					  }
					  else if (thirdLine.Contains(c))
					  {
						  moveBack = int.Parse(keyStr[2].ToString()) * -1;
						  chars = thirdLine;
					  }
				  }
				  var idx = chars.IndexOf(c);
				  return idx == -1 ?
					c :
					chars[(idx + moveBack) >= 0 ? idx + moveBack : chars.Length - 1 + (idx + moveBack + 1)];
			  }));
		}
	}
}
