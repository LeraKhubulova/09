using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст на английском (заканчивается точкой):");
        string text = Console.ReadLine().ToLower();
         string cleanText = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c) || c == '.')
                cleanText += c;
        }
        if (cleanText.Length == 0 || cleanText == ".")
        {
             Console.WriteLine("В тексте нет букв!");
            return;
        }
        int[] counts = new int[26];
         foreach (char c in cleanText)
        {
            if (char.IsLetter(c))
            {
                int index = c - 'a'; 
                counts[index]++;
            }
        }
        char maxChar = 'a';
         int maxCount = 0;

        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxChar= (char)('a' + i);
            }
        }

        Console.WriteLine($"Самая частая буква: '{maxChar}'");
        Console.WriteLine($"Количество: {maxCount}");
    }
}