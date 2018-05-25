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
			Console.WriteLine("hello world".ToAlternatingCase());
			Console.WriteLine("HELLO WORLD".ToAlternatingCase());
			Console.WriteLine("hello WORLD".ToAlternatingCase());
			Console.WriteLine("HeLLo WoRLD".ToAlternatingCase());
			Console.WriteLine("12345".ToAlternatingCase());
			Console.WriteLine("1a2b3c4d5e".ToAlternatingCase());
			Console.WriteLine("String.ToAlternatingCase".ToAlternatingCase());
			Console.WriteLine("Hello World".ToAlternatingCase().ToAlternatingCase());
			Console.ReadLine();
		}
	}

	public static class StringExt
	{
		public static string ToAlternatingCase(this string s)
		{
			return String.Concat(s.Select(f => char.IsUpper(f) ? char.ToLower(f) : char.IsLower(f) ? char.ToUpper(f) : f));
		}
	}
}
