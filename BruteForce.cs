using System;

public class BruteForce
{
    public static void Crack(string text)
    {
        
        string bestResult = "";
        int bestScore = -1;
        int bestKey = 0;
        
        for (int key = 0; key < 26; key++)
        {
            string result = CaesarCipher.Decrypt(text, key);
            
            int score = TextAnalyzer.Score(result);
            
            Console.WriteLine($"Chave {key}: {result} | Pontuação: {score}");
            
            if (score > bestScore)
            {
                bestScore = score;
                bestResult = result;
                bestKey = key;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("==== MELHOR CANDIDATO ====");
        Console.WriteLine($"Chave: {bestKey}");
        Console.WriteLine($"Pontuação: {bestScore}");
        Console.WriteLine($"Resultado: {bestResult}");
    }
}
