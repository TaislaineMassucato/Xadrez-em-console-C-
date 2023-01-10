using tabuleiro;
using Xadrex_Console;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
        }
    }   
}
