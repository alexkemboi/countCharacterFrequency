using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string input = "Hello, World!";
        Hashtable charFrequency = CountCharacterFrequency(input);

        foreach (DictionaryEntry entry in charFrequency)
        {
            char character = (char)entry.Key;
            int frequency = (int)entry.Value;
            Console.WriteLine($"Character: '{character}', Frequency: {frequency}");
        }
    }

    static Hashtable CountCharacterFrequency(string input)
    {
        Hashtable charFrequency = new Hashtable();

        foreach (char c in input)
        {
            if (charFrequency.ContainsKey(c))
            {
                int frequency = (int)charFrequency[c];
                charFrequency[c] = frequency + 1;
            }
            else
            {
                charFrequency.Add(c, 1);
            }
        }

        return charFrequency;
    }
}
