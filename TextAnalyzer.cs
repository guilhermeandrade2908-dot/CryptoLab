using System;

public class TextAnalyzer
{
    private static readonly string[] CommonWords =
    {
        "de",
        "da",
        "do",
        "que",
        "e",
        "é",
        "em",
        "um",
        "uma",
        "para",
        "com",
        "não",
        "por",
        "os",
        "as"
    };
    
    public static int Score(string text)
    {
        int score = 0;
        
        string normalizedText = text.ToLowerCase();
        
        foreach (string word in CommonWords)
        {
            if (normalizedText.Contains(word))
            {
                score++;
            }
        }
        
        return score;
    }
}
