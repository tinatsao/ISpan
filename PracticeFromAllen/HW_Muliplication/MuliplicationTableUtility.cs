using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_MuliplicationTableUtility
{
    internal class MuliplicationTableUtility
    {

        public void MuliplicationTable(int StartNumber,int EndNumber, int Multiplicand)
        {
			for (int i = StartNumber; i <= EndNumber; i++)
			{
				int result = Multiplicand*i;
				string resultformat = String.Format("{0,2}", result.ToString());
				Console.WriteLine($"{Multiplicand} * {i} = {resultformat}");
			}
			Console.WriteLine();
		}
    }
}
