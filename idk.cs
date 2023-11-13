using System;

class Hello
{
    static void Main(string[] args)  
    {
        Console.WriteLine("Hello, World");
        int res = 0;
        foreach(string arg in args)  
        {
            try
            {
                int temp = Int32.Parse(arg);
                res += temp;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{arg}'");
                return;
            }
        }
        Console.WriteLine(res);
    }

}
