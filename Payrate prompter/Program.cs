using System;

namespace PayPrompter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double payrate;


            do
            {
                Console.WriteLine("please enter a vaild payrate");
                payrate = double.Parse(Console.ReadLine());

            } while (payrate < 5.65 || payrate > 49.99);

            Console.WriteLine("The valid payrate that you entered is £{0}", payrate);
        }
    }
}