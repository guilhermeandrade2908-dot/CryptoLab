using System;
class Menu {
  static void Main() {
    
    bool executando = true;
    
    while (executando)
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
        Console.Write("Escolha uma opção: ");
        
        string opcao = Console.ReadLine() ?? "";
        
        switch (opcao)
        {
            case "1":
                Console.Write("Digite a mensagem: ");
                string mensagem = Console.ReadLine() ?? "";
                
                Console.Write("Digite a chave: ");
                if (int.TryParse(Console.ReadLine(), out int chave))
                {
                    string criptografada =
                        CaesarCipher.Encrypt(mensagem, chave);
                    
                    Console.WriteLine($"Resultado: {criptografada}");
                }
                else
                {
                    Console.WriteLine("Chave inválida! Digite uma chave valida.");
                }
                
                break;
            
            case "2":
                Console.Write("Digite a mensagem criptografada: ");
                string texto = Console.ReadLine() ?? "";
                
                Console.Write("Digite a chave: ");
                if (int.TryParse(Console.ReadLine(), out int chaveDec))
                {
                    string descriptografada =
                        CaesarCipher.Decrypt(texto, chaveDec);
                        
                    Console.WriteLine($"Resultado: {descriptografada}");
                }
                else
                {
                    Console.WriteLine("Chave inválida! Digite uma chave valida.");
                }
                
                break;
            
            case "3":
                Console.Write("Digite a mensagem criptografada: ");
                string textoCriptografado = Console.ReadLine() ?? "";
                
                BruteForce.Crack(textoCriptografado);
                break;
            
            case "0":
                executando = false;
                Console.WriteLine("Encerrando o CryptoLab...");
                break;
            
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        
        if (executando)
        {
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
  }
}
