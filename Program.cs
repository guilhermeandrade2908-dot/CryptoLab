using System;
class Menu {
  static void Main() {
    
    bool onOff = true;
    
    while (onOff)
    {
        Console.Clear();
        
        Console.WriteLine("==============================");
        Console.WriteLine("         CRYPTOLAB");
        Console.WriteLine("==============================");
        Console.WriteLine("1 - Criptografar mensagem");
        Console.WriteLine("2 - Descriptografar mensagem");
        Console.WriteLine("3 - Quebrar cifra");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("==============================");
        Console.Write("Escolha uma opção:");
    }
  }
}
