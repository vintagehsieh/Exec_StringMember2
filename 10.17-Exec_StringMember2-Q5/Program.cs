using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q5: 比對使用者輸入值是否為"Allen"，不拘大小寫
			string answer = "Allen";

			//A5
			//設定使用者輸入值
			Console.Write("請輸入\"Allen\"，大小寫不拘: ");
			string input = Console.ReadLine();

			//防呆
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入任何字。");
				return;
			}

			//比對
			if ( input.ToUpper() == answer.ToUpper())
			{
				if ( input.ToLower() == answer.ToLower())
				{
					Console.WriteLine("正確!");
					return;
				}
			}
			Console.WriteLine("錯誤!");
		}
	}
}
