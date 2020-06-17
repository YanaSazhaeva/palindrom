using System;

namespace palindrom
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
                Console.WriteLine("Wrong syntax. Please, use: 'palindrom <string>'");
            else
            {
                string input = args[0].ToString();
                int count = input.Length;
                bool is_palindrom = true;

                for (int i = 1; i < count && is_palindrom; i++)
                    if (input[i - 1] != input[count - i])
                        is_palindrom = false;

                if (is_palindrom)
                    Console.WriteLine("'{0}' is a palindrom", input);
                else
                    Console.WriteLine("'{0}' is NOT a palindrom", input);
            }
        }
    }
}
