using System;

public class CaesarCipher
{
    public static string Encrypt(string text, int key)
    {
        string result = "";
        
        key = ((key % 26) + 26) % 26;
        
        foreach (char character in text)
        {
            if (character >= 'A' && character <= 'Z')
            {
                char encrypted = (char)('A' + (character - 'A' + key) % 26);
                result += encrypted;
            }
            else if (character >= 'a' && character <= 'z')
            {
                char encrypted = (char)('a' + (character - 'a' + key) % 26);
                result += encrypted;
            }
            else
            {
                result += character;
            }
        }
        
        return result;
    }
}
  
