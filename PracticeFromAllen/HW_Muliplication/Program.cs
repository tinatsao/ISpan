using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_MuliplicationTableUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/// <summary>
			/// for 兩層
			/// </summary>
			for (int i = 2; i<= 9; i++)
            {
                for (int j = 1; j<= 9; j++) 
                {
                    int result = i*j;
                    string resultformat =String.Format("{0,2}", result.ToString());
                    Console.WriteLine($"{i} * {j} = {resultformat}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
