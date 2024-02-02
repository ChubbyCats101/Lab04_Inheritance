using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Inheritance
{
    public class Litten : Pokedex
    {
        public Litten() 
        {
            Name = "Litten";
            Id = 725;
            Level = 1;
            Type = PokemonType.Fire;
            Pic = Lab04Inheritance.Properties.Resources.Litten_7251;
            Hp = 45;
            Att = 60;
            Def = 40;
            SAtt = 60;
            SDef = 40;
            Speed = 70;
        }
    }
}
