using tabuleiro;
using xadrez;
using Xadrez_Console;

namespace xadrex_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Digite a origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicaoPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();

                        Tela.imprimirTabuleiro(partida.tab, posicaoPossiveis);

                        Console.WriteLine();

                        Console.Write("Digite o destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem,destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
