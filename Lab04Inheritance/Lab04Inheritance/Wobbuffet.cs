using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Inheritance
{
    public class Wobbuffet : Pokedex
    {
        public Wobbuffet() 
        {
            Name = "Wobbuffet";
            Id = 202;
            Level = 1;
            Type = PokemonType.Psychc;
            Pic = Lab04Inheritance.Properties.Resources.Wobbuffet_2021;
            Hp = 190;
            Att = 33;
            Def = 58;
            SAtt = 33;
            SDef = 58;
            Speed = 33;
        }
    }
}
