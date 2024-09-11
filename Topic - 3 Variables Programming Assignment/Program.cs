using System.Net.Sockets;

namespace Topic___3_Variables_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiago
            int num1, num2;
            string word;
            double price = 11;

            word = "sum: ";
            num1 = 9;
            num2 = 10;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(word + num1 + num2);
            Console.WriteLine(word + (num1 + num2));

            Console.WriteLine();
            Console.WriteLine();

            int cost = 11;
            int weight = 2;
            Console.WriteLine(cost / weight);
            Console.WriteLine(price / weight);
        }
    }
}
