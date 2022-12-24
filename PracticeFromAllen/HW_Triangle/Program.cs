using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            //Q1 正三角形
            Console.WriteLine("Q1:正三角形");
            const int rowsQ1 = 5;
            for (int i = 1; i <= rowsQ1; i++)
            {
                string Rowcontent = new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();

            //Q2 倒三角形
            Console.WriteLine("Q2:倒三角形");
            const int rowsQ2 = 5;
            for (int i = rowsQ2; i >= 1; i--)
            {
                string Rowcontent = new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();

            //Q3 靠右對齊三角形
            Console.WriteLine("Q3:靠右對齊三角形");
            const int rowsQ3 = 5;
            for (int i = 1; i <= rowsQ3; i++)
            {
                int complementPair = (rowsQ3 - i);
                string Rowcontent = new string(' ', complementPair) + new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();

            //Q4 靠右對齊倒三角形
            Console.WriteLine("Q4 靠右對齊倒三角形");
            const int rowsQ4 = 5;
            for (int i = 5; i >= 1; i--)
            {
                int complementPair = (rowsQ4 - i);
                string Rowcontent = new string(' ', complementPair) + new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();

            //Q5 等腰三角形
            Console.WriteLine("Q5 等腰三角形");
            const int rowsQ5 = 4;
            for (int i = 1; i <= (rowsQ5 * 2) - 1; i += 2)
            {
                int complementPair = (rowsQ5 * 2 - i) / 2;
                string Rowcontent = new string(' ', complementPair) + new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();
            //Q6 等腰三角形
            Console.WriteLine("Q6 倒等腰三角形");
            const int rowsQ6 = 4;
            for (int i = (rowsQ5 * 2) - 1; i >= 1; i -= 2)
            {
                int complementPair = (rowsQ6 * 2 - i) / 2;
                string Rowcontent = new string(' ', complementPair) + new string('*', i);
                Console.WriteLine(Rowcontent);
            }
            Console.ReadKey();
        }
    }
}