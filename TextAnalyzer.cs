using System;
using System.Collections.Generic;

public class TextAnalyzer
{
    private static readonly Dictionary<string, int> CommonWords = new()
    {
        {"de", 1},
        {"da", 1},
        {"do", 1},
        {"que", 2},
        {"e", 1},
        {"é", 2},
        {"em", 1},
        {"um", 1},
        {"uma", 1},
        {"para", 2},
        {"com", 2},
        {"não", 3},
        {"por", 1},
        {"os", 1},
        {"as", 1}
    };
    
    public static int Score(string text)
    {
        int score = 0;
        
        string normalizedText = text.ToLower();
        
        string[] words = normalizedText.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );
        
        foreach (string word in words)
        {
            if (CommonWords.ContainsKey(word))
            {
                score += CommonWords[word];
            }
        }
        
        return score;
    }
}
