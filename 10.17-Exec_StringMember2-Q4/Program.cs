using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q4: 假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"

			//A4: 用字串更替的方式
			string dateMingGuo = "1100225";
			int yearOfCE = Convert.ToInt32(dateMingGuo.Substring(0, 3)) + 1911;
			string dateInCE = Convert.ToString(yearOfCE) + dateMingGuo.Substring(dateMingGuo.Length - 4);
			Console.WriteLine(dateInCE);

		}
	}
}
