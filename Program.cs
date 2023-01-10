﻿using tabuleiro;
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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();

                    Console.Write("Digite a origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Digite a destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
