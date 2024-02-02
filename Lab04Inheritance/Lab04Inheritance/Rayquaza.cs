using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04Inheritance
{
    public class Rayquaza : Pokedex
    {
        public Rayquaza()
        {
            Name = "Rayquaza";
            Id = 384;
            Level = 1;
            Type = PokemonType.Dragon | PokemonType.Flying;
            Pic = Lab04Inheritance.Properties.Resources.Rayquaza_3841;
            Hp = 105;
            Att = 150;
            Def = 90;
            SAtt = 150;
            SDef = 90;
            Speed = 95;
        }
    }
}
