using System;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typing data:");
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i<6;i++)
            {
                var typingString = Console.ReadLine();
                try
                {
                    resultString.Append(typingString[0]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Exception: Type any symbols!");
                    --i;
                }
            }

            Console.WriteLine(resultString);
        }
    }
}
