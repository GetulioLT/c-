using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Personagens
    {

        protected Random dado = new Random();

        protected int vida, defesa, ataque;

        abstract protected void Atacar();
    
        abstract protected void Defender();

    }
}
