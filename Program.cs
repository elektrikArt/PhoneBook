using System;
using System.Collections.Generic;
using System.Linq;

int kitsCount = int.Parse(Console.ReadLine() ?? "_");

for (int _ = 0; _ < kitsCount; _++)
{
    int recordsCount = int.Parse(Console.ReadLine() ?? "_");
    var phoneBook = new Dictionary<string, Stack<string>>();
    for (int __ = 0; __ < recordsCount; __++)
    {
        string[] items = (Console.ReadLine() ?? "_").Split(' ');
        string person = items[0];
        string phone = items[1];

        if (phoneBook.ContainsKey(person) == false)
            phoneBook.Add(person, new Stack<string>());
        phoneBook[person].Push(phone);
    }

    foreach (var record in phoneBook.OrderBy(r => r.Key))
    {
        var filtredPhones = record.Value.Distinct().Take(5);

        Console.Write($"{record.Key}: {filtredPhones.Count()}");
        foreach (string phone in filtredPhones)
            Console.Write($" {phone}");
        Console.WriteLine();
    }
    Console.WriteLine();
}