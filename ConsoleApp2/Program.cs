using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation1
{
	class Program
	{
		const int NUM = 4;
		static char[] tbl = new char[] {'a','b','c','d'};

		public static void Main()
		{
			jyun(tbl, -1);
			Console.ReadLine();
		}

		// 順列を求める
		static void jyun(char[] t, int n)
		{
			int i, k;
			char word = ' ';

			if (n == t.Length - 1)
			{
				list();
				return;
			}
			k = n + 1;
			for (i = n + 1 ; i <= t.Length - 1; i++)
			{
				word = t[k];
				t[k] = t[i];
				t[i] = word;
				jyun(t, k);
				t[i] = t[k];
				t[k] = word;
			}
		}

		// 順列を List
		static void list()
		{
			int i;
			for (i = 0; i < tbl.Length; i++) Console.Write("{0, -2} ", tbl[i]);
			Console.WriteLine("");
		}
	}
}
