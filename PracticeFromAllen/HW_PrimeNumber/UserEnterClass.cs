using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_2PrimeNumberConsole
{
	internal class UserEnterClass
	{
		public static bool IsNumeric(string TextBoxValue)
		{
			bool result =int.TryParse(TextBoxValue, out int value);
			if (result == false || value < 2)
			{
				return false;
			}
			else
			{
				return true;
			}
	
		}
	}
}
