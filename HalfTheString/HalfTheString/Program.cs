using System;

namespace HalfTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string which its length is an even number: ");
            string str = Console.ReadLine();

            if (str.Length % 2 == 0)
            {
                string strHalf = str.Remove(str.Length / 2);
                Console.WriteLine(strHalf);
            }
            else
            {
                Console.WriteLine("The string is invalid.");
            }

            Console.Write("\nEnter any key to continue ...");
            Console.ReadKey();
        }
    }
}