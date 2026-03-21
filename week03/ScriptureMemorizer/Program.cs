using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<Scripture> scriptures = new List<Scripture>()
{
    new Scripture(
        new Reference("Philippians", 4, 13),
        "I can do all things through Christ which strengtheneth me."
    ),
    new Scripture(
        new Reference("Joshua", 1, 9),
        "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest."
    ),
    new Scripture(
        new Reference("Alma", 37, 6),
        "By small and simple things are great things brought to pass."
    )
};
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter or type 'quit': ");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}