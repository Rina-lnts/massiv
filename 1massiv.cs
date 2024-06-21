using System;

class Program
{
    static void Main()
    {
        string[] strings = { "aaa", "bbb", "vvv", "gggg", "ccc" };

        Console.Write("Введите строку: ");
        string newString = Console.ReadLine();

        bool found = false;
        foreach (string str in strings)
        {
            if (str == newString)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}


