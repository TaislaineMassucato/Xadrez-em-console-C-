using tabuleiro;
using xadrez;
using Xadrex_Console;

namespace xadrex_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('g', 5);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.WriteLine();
        }
    }
}
