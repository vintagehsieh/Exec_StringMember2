using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_StringMember2_Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_StringMember2
			//Q8: 隱藏手機的資訊，呈現0935****46 

			//A8-1(方法一): 指定手機號碼，並隱藏第五位到第八位號碼
			string phoneNumber = "0935123446";

			string hiddenPhoneNumber = phoneNumber.Substring(0, 4) + new string('*', 4) + phoneNumber.Substring(phoneNumber.Length - 2);
			Console.WriteLine(hiddenPhoneNumber);
			Console.WriteLine();


			//A8-2(方法二): 輸入任意手機號碼並隱藏第五至第八位號哈
			Console.Write("請輸入您的手機號碼: ");
			string yourPhoneNum = Console.ReadLine();

			//防呆
			if (string.IsNullOrEmpty(yourPhoneNum))
			{
				Console.WriteLine("您沒有輸入手機號碼，請再次輸入");
				return;
			}

			if (yourPhoneNum.Length != 10 )
			{
				Console.WriteLine("您輸入的手機號碼可能有錯，請再次檢查");
				return;
			}

			//判斷
			string hiddenYourPhone = yourPhoneNum.Substring(0, 4) + new string('*', 4) + yourPhoneNum.Substring(yourPhoneNum.Length - 2);
			Console.WriteLine(hiddenYourPhone);

		}
	}
}
