using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Exec_StringMember2
			//Q1: 將" abc "左右的空白刪除 
			//除左.TrimStart 除右.TrimEnd

			//A1:
			string target = " abc ";
			string result = target.Trim();
			Console.WriteLine(result);
		}
	}
}
