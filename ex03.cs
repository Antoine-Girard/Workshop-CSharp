using System;

class Hello
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");
        int[] list = { 1, 2, 3 };

        foreach (string arg in args)
        {
            try
            {
                int temp = Int32.Parse(arg);
                int index = Function(list, temp);
                Console.WriteLine("index: " + index);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{arg}'");
            }
        }
    }

    static int Function(int[] list, int nbr)
    {
        int idx = 0;

        foreach (int arg in list)
        {
            if (arg == nbr)
                return idx;
            idx++;
        }
        return -1;
    }
}
