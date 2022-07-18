using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPG
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int delay;
            Console.WriteLine("Você está preste a entrar em uma versão beta de um jogo de realidade Virtual chamado: Arte das Espadas.\n" +
                "Onde se tem 5 andares para essa versão, teremos 3 tipo de estilos: empunhaduradura de espada unica, empunhadura de duas espadas e espada e escurdo.\n" +
                "Você está como o dedo no botão de iniciar.\n" +
                "Precione enter para continuar");
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(delay = 600);
                Console.Write('.');

            }
            Console.Clear();
            Historia historia = new Historia();

            Console.ReadLine();


        }
    }
}
