using System;

namespace Aula_de_PC1_AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("Ajude a aranha sair da caixa! Aperte qualquer botão:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Esta é a prisão da aranha...");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("  _____\n |     |\n |     |\n |     |\n |_____|\n \n");
            Console.ResetColor();
            Console.WriteLine("Tecle *Enter* para abrir a caixa.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" ||     ||     ____\n \\\\[* *]//    |    |\n //[___]\\\\    |    | \n ||     ||    |____|");
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("\n !PARABÉNS! Você salvou a aranha!");
            Console.ResetColor();
            
        }
    }
}
