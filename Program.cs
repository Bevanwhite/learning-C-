using System;

namespace Learning_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($@"Testing \n 1 2 {5-2}
New line");
            var str = @"""I don't think so,"" he said.";
            Console.WriteLine(str);

            // without using  @ 
            var filename = "c:\temp\newfile.txt";
            Console.WriteLine(filename);

            var multilineWithDoubleQuotes =@"I went to a city named
                                    ""San Diego""                      
                                during summer vacation.";
            
            Console.WriteLine(multilineWithDoubleQuotes);
        }
    }
}
