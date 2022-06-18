/*
    Criando um tabuleiro de Jogo da Velha
    Crie um tabuleiro de jogo da velha, usando uma matrizes de caracteres (char) 3×3, onde o usuário pede 
    o número da linha (1 até 3) e o da coluna (1 até 3). A cada vez que o usuário entrar com esses dados, 
    colocar um ‘X’ ou ‘O’ no local selecionado
 */
using System;
using System.Collections.Generic;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================ Váriaveis ================*/

            char[,] tabuleiro = new char[3,3];

            bool a1 = false;
            bool a2 = false;
            bool a3 = false;
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            bool c1 = false;
            bool c2 = false;
            bool c3 = false;

            int k;
            int l;
            int a = 1;
            int b = 1;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            for (int i = 0; i < 4; i++)
            {
                //jogador 1

                ret1:
                Console.WriteLine("Altura:");
                Console.Write("");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("largura:");
                Console.Write("");
                l = int.Parse(Console.ReadLine());

                if (k > 3 || l > 3)
                {
                    goto ret1;
                }

                if (tabuleiro[0,0] == tabuleiro[k,l] && a1 != true)
                {
                    a1 = true;
                    tabuleiro[0, 0] = 'X';
                }
                else if (tabuleiro[0, 1] == tabuleiro[k, l] && a2 != true)
                {
                    a2 = true;
                    tabuleiro[0, 1] = 'X';
                }
                else if (tabuleiro[0, 2] == tabuleiro[k, l] && a3 != true)
                {
                    a3 = true;
                    tabuleiro[0, 2] = 'X';
                }
                else if (tabuleiro[1, 0] == tabuleiro[k, l] && b1 != true)
                {
                    b1 = true;
                    tabuleiro[1, 0] = 'X';
                }
                else if (tabuleiro[1, 1] == tabuleiro[k, l] && b2 != true)
                {
                    b2 = true;
                    tabuleiro[1, 1] = 'X';
                }
                else if (tabuleiro[1, 2] == tabuleiro[k, l] && b3 != true)
                {
                    b3 = true;
                    tabuleiro[1, 2] = 'X';
                }
                else if (tabuleiro[2, 0] == tabuleiro[k, l] && c1 != true)
                {
                    c1 = true;
                    tabuleiro[2, 0] = 'X';
                }
                else if (tabuleiro[2, 1] == tabuleiro[k, l] && c2 != true)
                {
                    c2 = true;
                    tabuleiro[2, 1] = 'X';
                }
                else
                {
                    c3 = true;
                    tabuleiro[2, 2] = 'X';
                }

                //jogador 2

                ret2:
                Console.WriteLine("Altura:");
                Console.Write("");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("largura:");
                Console.Write("");
                l = int.Parse(Console.ReadLine());

                if (k > 3 || l > 3)
                {
                    goto ret2;
                }

                if (tabuleiro[0, 0] == tabuleiro[k, l] && a1 != true)
                {
                    a1 = true;
                    tabuleiro[0, 0] = 'O';
                }
                else if (tabuleiro[0, 1] == tabuleiro[k, l] && a2 != true)
                {
                    a2 = true;
                    tabuleiro[0, 1] = 'O';
                }
                else if (tabuleiro[0, 2] == tabuleiro[k, l] && a3 != true)
                {
                    a3 = true;
                    tabuleiro[0, 2] = 'O';
                }
                else if (tabuleiro[1, 0] == tabuleiro[k, l] && b1 != true)
                {
                    b1 = true;
                    tabuleiro[1, 0] = 'O';
                }
                else if (tabuleiro[1, 1] == tabuleiro[k, l] && b2 != true)
                {
                    b2 = true;
                    tabuleiro[1, 1] = 'O';
                }
                else if (tabuleiro[1, 2] == tabuleiro[k, l] && b3 != true)
                {
                    b3 = true;
                    tabuleiro[1, 2] = 'O';
                }
                else if (tabuleiro[2, 0] == tabuleiro[k, l] && c1 != true)
                {
                    c1 = true;
                    tabuleiro[2, 0] = 'O';
                }
                else if (tabuleiro[2, 1] == tabuleiro[k, l] && c2 != true)
                {
                    c2 = true;
                    tabuleiro[2, 1] = 'O';
                }
                else
                {
                    c3 = true;
                    tabuleiro[2, 2] = 'O';
                }

                
                
            }

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            

            /*===========================================*/

            
            Console.ReadLine();
        }
    }
}