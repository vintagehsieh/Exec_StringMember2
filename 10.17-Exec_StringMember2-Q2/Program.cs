using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q2: 將字串"Allen Kuo"轉成大寫"ALLEN KUO"

			//A2
			string target = "Allen Kuo";
			string result = target.ToUpper();
			Console.WriteLine(result);

		}
	}
}
