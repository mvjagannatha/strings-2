using System;

namespace Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i = 0;
            Console.Write("Enter a string:");
            str = Console.ReadLine();
            char[] nstr = new char[str.Length]; //Convert a string into character array.
            while (i < str.Length)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                {
                    nstr[i] = str[i];
                }
                nstr[i]++;
                i++;
            }
            
            Console.Write(nstr);
            Console.ReadKey();
        }
    }
}