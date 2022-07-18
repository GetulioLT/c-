using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract public class Inimigos
    {

        protected string nome, raça;
        protected int vida, ataque, defesa;

        abstract protected void Ataque();

        abstract protected void Defesa();

        abstract protected void Esperar();

    }
}
