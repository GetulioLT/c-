using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPG
{
    internal class Historia
    {

        Random dado = new Random();

        bool espadaUni, espadaDup, espadaEscudo;
        string nome, confirma;
        int escolha;

        public Historia()
        {

            Console.WriteLine("Olá bem-vindo a Artes Da Espada.\n" +
                "Primeiramente digite seu nick:");

        returnNome:

            nome = Console.ReadLine();

            Console.WriteLine($"Hum... {nome} que nome interessante. Você confirma esse nome?(s/n)");
            confirma = Console.ReadLine();

            if (confirma.ToUpper() == "S")
            {

            }
            else
            {
                Console.WriteLine("\nDigite seu nome novamente:");
                goto returnNome;
            }
        returnEstilo:
            Console.Clear();

            Console.WriteLine("Agora qual estilo você irá seguir:\n" +
                "1 - Estilo Espada Unica\n" +
                "2 - Estilo Duas Espadas\n" +
                "3 - Espada e Escudo\n" +
                "4 - Girar dado para escolha");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine("Você Escolheu Estilo Espada Unica\n" +
                        "Esse é o estilo padrão do game, onde não contará com defesa a mais, mas conta com a sorte\n" + //Fim do console
                        "de poder atacar duas vezes na mesma rodada e tem um ataque mais preciso tendo um modificador de 2 de dano\n" +
                        "Vida Inicial - 50\n" +
                        "Modificador de defesa - 0\n" +
                        "Modificador de ataque - +2\n" +
                        "\n\nConfirma esse personagem?(s/n)");
                    confirma = Console.ReadLine();

                    if (confirma.ToUpper() == "S")
                    {

                    }
                    else
                    {

                        goto returnEstilo;
                    }


                    break;


                case 2:

                    Console.Clear();

                    Console.WriteLine("Você Escolheu Estilo Duas Espadas\n" +
                        "Esse estilo são para aqueles que querem causar maior dano em menos tempo, você irá sempre dar dois ataques no \n" +
                        "mesmo turno, mas tem a precisão menor assim dará 1 de dano a menos e sua defesa é reduzida também, mas não é um\n" +
                        "personagem ruim tem um aumento de 10 de vida\n" +
                        "Vida Inicial - 60\n" +
                        "Modificador de defesa - -2\n" +
                        "Modificador de ataque - -2\n" +
                        "\n\nConfirma esse personagem?(s/n)");
                    confirma = Console.ReadLine();

                    if (confirma.ToUpper() == "S")
                    {

                    }
                    else
                    {

                        goto returnEstilo;
                    }

                    break;


                case 3:

                    Console.Clear();

                    Console.WriteLine("Você Escolheu Estilo Espada e Escudo\n" +
                        "Esse estilo para quem quer ter um jogo mais seguro, entre aspas clara, pois será um jogo mais demorado pelo simples \n" +
                        "motivo seu escudo é muito pesado atrapalhando seu ataque, tendo assim 3 de dano a menos por padrão, mas claro tendo \n" +
                        "um escudo desse tamanho seu modificador é +2, alem de ter uma mitigação de dano de 3 por turno e sua vida inicial é \n" +
                        "de 30 a mais\n" +
                        "Vida Inicial - 80\n" +
                        "Modificador de defesa - +2\n" +
                        "Modificador de ataque - -3\n" +
                        "\n\nConfirma esse personagem?(s/n)");
                    confirma = Console.ReadLine();

                    if (confirma.ToUpper() == "S")
                    {

                    }
                    else
                    {

                        goto returnEstilo;

                    }

                    break;


                case 4:

                    Console.Clear();

                    Console.WriteLine("Hum... Então você é uma pessoa que gosta de desafio né?\n" +
                        "Vamos girar o dado então:\n" +
                        "1 - Estilo Espada Unica\n" +
                        "2 - Estilo Duas Espadas\n" +
                        "3 - Espada e Escudo\n");

                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(500);
                        Console.Write('.');
                    }

                    Console.WriteLine();

                    switch (dado.Next(1, 4))
                    {
                        case 1:

                            Console.WriteLine("O sorteado foi o Estilo Espada Unica\n" +
                        "Esse é o estilo padrão do game, onde não contará com defesa a mais, mas conta com a sorte\n" + //Fim do console
                        "de poder atacar duas vezes na mesma rodada e tem um ataque mais preciso tendo um modificador de 2 de dano\n" +
                        "Vida Inicial - 50\n" +
                        "Modificador de defesa - 0\n" +
                        "Modificador de ataque - +2\n");

                            break;


                        case 2:

                            Console.WriteLine("O sorteado foi o Estilo Duas Espadas\n" +
                        "Esse estilo são para aqueles que querem causar maior dano em menos tempo, você irá sempre dar dois ataques no \n" +
                        "mesmo turno, mas tem a precisão menor assim dará 1 de dano a menos e sua defesa é reduzida também, mas não é um\n" +
                        "personagem ruim tem um aumento de 10 de vida\n" +
                        "Vida Inicial - 60\n" +
                        "Modificador de defesa - -2\n" +
                        "Modificador de ataque - -2\n");

                            break;


                        case 3:

                            Console.WriteLine("O sorteado foi o Estilo Espada e Escudo\n" +
                        "Esse estilo para quem quer ter um jogo mais seguro, entre aspas clara, pois será um jogo mais demorado pelo simples \n" +
                        "motivo seu escudo é muito pesado atrapalhando seu ataque, tendo assim 3 de dano a menos por padrão, mas claro tendo \n" +
                        "um escudo desse tamanho seu modificador é +2, alem de ter uma mitigação de dano de 3 por turno e sua vida inicial é \n" +
                        "de 30 a mais\n" +
                        "Vida Inicial - 80\n" +
                        "Modificador de defesa - +2\n" +
                        "Modificador de ataque - -3\n");

                            break;


                    }


                    break;


                default:

                    Console.WriteLine("Essa escolha não existe escolha novamente:");

                    Thread.Sleep(3000);

                    goto returnEstilo;

            }

        }
    }
}
