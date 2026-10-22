using System;
using System.Collections.Generic;

public class FrequencyAnalyzer
{
    public static Dictionary<char, int> CountLetters(string text)
    {
        Dictionary<char, int> frequencies = new()
        
        foreach (char character in text.ToLower())
        {
            if (character >= 'a' && character <= 'z')
            {
                if (frequencies.ContainsKey(character))
                {
                    frequencies[character]++;
                }
                else
                {
                    frequencies[character] = 1;
                }
            }
        }
        
        return frequencies;
    }
    
    public static void DisplayFrequency(string text)
    {
        Dictionary<char, int> frequencies = CountLetters(text);
        
        Console.WriteLine("===== FREQUÊNCIA DAS LETRAS =====");
        
        foreach (var item in frequencies)
        {
            Console.WriteLine($"{item.key}: {item.value}");
        }
    }
}
