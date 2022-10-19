using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q3: 將字串 "aLLeN kUO" 轉成 "Allen Kuo";
			string name = "aLLeN kUO";

			//A3:
			//切割姓和名字
			string[] nameData = name.Split(' ');
			string firstName = nameData[0];	
			string firstNameInLower = firstName.ToLower();	
	
			string lastName = nameData[1];
			string lastNameInLower = lastName.ToLower();

			//名字全改小寫
			string nameInLowerCase = name.ToLower();

			//切割後，將第一個字母轉成大寫
			string firCharInFirName = firstName.Substring(0, 1);
			var capitalA = firCharInFirName.ToUpper();	

			string firCharInLaName = lastName.Substring(0,1);	
			var capitalK = firCharInLaName.ToUpper();

			Console.WriteLine($"{capitalA}{firstNameInLower.Substring(1)} {capitalK}{lastNameInLower.Substring(1)}");

		}
	}
}
