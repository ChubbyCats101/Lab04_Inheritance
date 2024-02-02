using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04Inheritance
{
    public class Raikou : Pokedex
    {
        public Raikou()
        {
            Name = "Raikou";
            Id = 243;
            Level = 1;
            Type = PokemonType.Electr;
            Pic = Lab04Inheritance.Properties.Resources.raikou_2431;
            Hp = 90;
            Att = 85;
            Def = 75;
            SAtt = 115;
            SDef = 100;
            Speed = 115;
        }
    }
}
