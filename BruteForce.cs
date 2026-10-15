using System;

public class BruteForce
{
    public static void Crack(string text)
    {
        for (int key = 0; key < 26; key++)
        {
            string result = CaesarCipher.Decrypt(text, key);
            
            Console.WriteLine($"Chave {key}: {result}");
        }
    }
}
