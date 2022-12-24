using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q03_2PrimeNumberConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string UserInput;
			//ConsoleKey key;
			while(true)
			{
				UserInput = Console.ReadLine();
				if (UserEnterClass.IsNumeric(UserInput) ==false) 
				{ 
					Console.WriteLine("請輸入大於1的數字");
				}
				else
				{
					bool result = IsPrime(Convert.ToInt32(UserInput));
					Console.WriteLine(result);
				}
			};

		}
		static bool IsPrime(int Num)
		{
			if ((Num % 2)== 0 && Num != 2) { return false; };
			for (int i = 2; i <= (int)Math.Sqrt(Num); i++)
			{
				if(Num % i == 0 )
				{
					return false;
				}
			}
			return true;
		}

	}
}
