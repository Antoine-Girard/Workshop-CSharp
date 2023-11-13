using System;

class Hello
{
    static void Main(string[] args)
    {
        int[] list = { 1, 2, 3 };

        foreach (string arg in args)
        {
            try
            {
                int temp = Int32.Parse(arg);
                Function(list, temp);
                Console.WriteLine("tab: " + string.Join(", ", list));
                list[0] = 1;
                list[1] = 2;
                list[2] = 3;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{arg}'");
            }
        }
    }

    static void Function(int[] list, int nbr)
    {
        int idx = 0;

        foreach (int arg in list)
        {
            list[idx] += nbr;
            idx++;
        }
    }
}
