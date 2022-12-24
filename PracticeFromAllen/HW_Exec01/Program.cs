using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exec01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            member.Name = "Allen";
            string greeting = member.Greet("Hello"); // Hello, Allen
            Console.WriteLine(greeting);

            Member member2 = new Member();
            string greeting2 = member2.Greet("Hello"); // Hello
			Console.WriteLine(greeting2);

		}
    }

    public class Member
    {
        private string _name;
        public string Name 
        {
            get 
            {
                return _name;
            }
            
            set 
            {
                _name = value;
			}
        }

        /// <summary>
        /// 傳回 'Hello, Allen'
        /// 如果 Name 沒有值, 傳回 'Hello'
        /// </summary>
        /// <param name="greeting"></param>
        /// <returns></returns>
        public string Greet(string greeting) 
        {
            if (_name==null)
            {
                return greeting;
			}
            else
            {
				return _name + " "+ greeting;
			}
        }

    }
}
