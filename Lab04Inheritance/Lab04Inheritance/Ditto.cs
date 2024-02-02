using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04Inheritance
{
    public class Ditto : Pokedex
    {
        public Ditto() 
        {
            Name = "Ditto";
            Id = 132;
            Level = 1;
            Type = PokemonType.Electr;
            Pic = Lab04Inheritance.Properties.Resources.ditto_1321;
            Hp = 48;
            Att = 48;
            Def = 48;
            SAtt = 48;
            SDef = 48;
            Speed = 48;
        }
    }
}
