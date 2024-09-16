using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_imput
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //North
            string name;
            int age;

            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Hi " + name + " How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
           
        }
    }
}
