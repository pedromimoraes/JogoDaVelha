﻿using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo e inicializando a variável contendo o tabuleiro do jogo da velha.
            string[,] tabuleiro = new string[3, 3];

            // Definindo o jogador.
            string jogador;

            // Definindo variável para controle de turnos.
            int turno = 0;

            // Prenchendo os espaços vazios do tabuleiro.
            int contador = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = contador.ToString();
                    contador++;
                }

            }

            while (turno < 9)
            {
                // Lógica para alternança de turnos.
                if (turno % 2 == 0)
                {
                    jogador = "X";
                }
                else
                {
                    jogador = "O";
                }

                System.Console.WriteLine($"Vez de {jogador}");

                // Mostrando o tabuleiro na tela.
                System.Console.WriteLine($"{tabuleiro[0, 0]} | {tabuleiro[0, 1]} | {tabuleiro[0, 2]}");
                System.Console.WriteLine($"{tabuleiro[1, 0]} | {tabuleiro[1, 1]} | {tabuleiro[1, 2]}");
                System.Console.WriteLine($"{tabuleiro[2, 0]} | {tabuleiro[2, 1]} | {tabuleiro[2, 2]}");

                // Solicita uma posição do tabuleiro pro jogador jogar
                System.Console.WriteLine($"Escolha uma posição: ");
                string posicao = Console.ReadLine();

                // Marca o simbolo na posição desejada.
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (posicao == tabuleiro[i, j])
                        {
                            tabuleiro[i, j] = jogador;
                        }
                    }

                }

                //TODO: Criar lógica para definir vencedor.

                // Verifica se X ganhou na horizontal.
                if (tabuleiro[0, 0] == "X" && tabuleiro[0, 1] == "X" && tabuleiro[0, 2] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }
                else if (tabuleiro[1, 0] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[1, 2] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }
                else if (tabuleiro[2, 0] == "X" && tabuleiro[2, 1] == "X" && tabuleiro[2, 2] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }

                // Verifica se o X ganhou na vertical.
                if (tabuleiro[0, 0] == "X" && tabuleiro[1, 0] == "X" && tabuleiro[2, 0] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }
                else if (tabuleiro[0, 1] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 1] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }

                else if (tabuleiro[0, 2] == "X" && tabuleiro[1, 2] == "X" && tabuleiro[2, 2] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }

                // Verifica se o X ganhou na vertical.
                if (tabuleiro[0, 0] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 2] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == "X" && tabuleiro[1, 1] == "X" && tabuleiro[2, 0] == "X")
                {
                    System.Console.WriteLine("X venceu!");
                    break;
                }




                // Verifica se O ganhou na horizontal.
                if (tabuleiro[0, 0] == "O" && tabuleiro[0, 1] == "O" && tabuleiro[0, 2] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }
                else if (tabuleiro[1, 0] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[1, 2] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }
                else if (tabuleiro[2, 0] == "O" && tabuleiro[2, 1] == "O" && tabuleiro[2, 2] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }

                // Verifica se o O ganhou na vertical.
                if (tabuleiro[0, 0] == "O" && tabuleiro[1, 0] == "O" && tabuleiro[2, 0] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }
                else if (tabuleiro[0, 1] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 1] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }

                else if (tabuleiro[0, 2] == "O" && tabuleiro[1, 2] == "O" && tabuleiro[2, 2] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }

                // Verifica se o O ganhou na vertical.
                if (tabuleiro[0, 0] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 2] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == "O" && tabuleiro[1, 1] == "O" && tabuleiro[2, 0] == "O")
                {
                    System.Console.WriteLine("O venceu!");
                    break;
                }

                // Iteração para limitar o while do jogo.
                turno++;
            }

        }
    }
}