using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_2_StringChangeConsole
{
	internal class Program
	{
		//還好公司有我...的程式碼...(汗顏)
		static void Main(string[] args)
		{
			String InputString = "AppleCat";
			Console.WriteLine(StringChange(InputString));
			String InputString2 = "MCHammer";
			Console.WriteLine(StringChange(InputString2));
		}

		static string StringChange(string UserInput)
		{
			string ChangeString = "";
			if (UserInput is null || UserInput == "")
			{
				return UserInput;
			}
			else
			{
				int counter = 0;
				foreach (char item in UserInput)
				{
					counter++;
					if (counter == 1 && char.IsUpper(item))
					{
						ChangeString += char.ToLower(item);
					}
					else if (char.IsUpper(item))
					{
						ChangeString = ChangeString + "_" + char.ToLower(item);
					}
					else
					{
						ChangeString += item;
					}
				}
				return ChangeString;
			}
		}
	}
}
