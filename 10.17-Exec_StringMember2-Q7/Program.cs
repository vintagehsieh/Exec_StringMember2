using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q7: 計算兩數之和，並只呈現小數二位數

			//A7-1(方法一): 指定兩個小數值
			double pi = 3.141592653;
			double naturalConstant = 2.718281828;
			double sum = pi + naturalConstant;
			Console.WriteLine($"{sum: #.##}");
			Console.WriteLine();

			//A7-2(方法二): 輸入任意兩數值
			Console.Write("請輸入第一個值: ");
			double num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("請輸入第二個值: ");
			double num2 = Convert.ToDouble(Console.ReadLine());

			//兩數之合，並顯示小數二位數
			Console.WriteLine($"{num1 + num2: #########.##}");


		}
	}
}
