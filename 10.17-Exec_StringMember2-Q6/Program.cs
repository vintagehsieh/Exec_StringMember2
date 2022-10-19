using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q6: 比對使用者輸入值是否為"Allen"，區分大小寫 
			string answer = "Allen";
			
			
			//A6-1(方法一): 指定使用者輸入值
			string input = "ALLEN";

			if ( input == answer) 
			{
				Console.WriteLine("正確!");
			}
			Console.WriteLine("您輸入的大小寫可能有誤!");
			Console.WriteLine();

			//A6-2(方法二): 請使用者自行輸入
			Console.Write("請輸入\"Allen\"，大小寫需區分: ");
			string inputWord = Console.ReadLine();

			if (string.IsNullOrEmpty(inputWord))
			{
				Console.WriteLine("您沒有輸入文字，請重新輸入");
				return;
			}

			if ( inputWord == answer)
			{
				Console.WriteLine("正確!");
				return;
			}
			Console.WriteLine("您輸入的大小寫可能有誤!");
			Console.WriteLine();

		}
	}
}
