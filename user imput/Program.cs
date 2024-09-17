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
            string name, pizzatoppping;
            int age = 11;
            double price1, price2, tax, subtotal, total;



            name = "45";
            Console.WriteLine(age);

            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Hi " + name + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(age);
            Console.ReadLine();

            Console.WriteLine(" Hey again, what is your favorate pizza topping? ");
            pizzatoppping = Console.ReadLine();
            Console.WriteLine("Funny my favorate pizza toping is also " + pizzatoppping);
            Console.ReadLine();
        }
    }
}
