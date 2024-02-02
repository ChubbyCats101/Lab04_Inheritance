using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Inheritance
{
    public class Cinderace : Pokedex
    {
        public Cinderace() 
        {
            Name = "Cinderace";
            Id = 815;
            Level = 1;
            Type = PokemonType.Fire;
            Pic = Lab04Inheritance.Properties.Resources.Cinderace_8151;
            Hp = 80;
            Att = 116;
            Def = 75;
            SAtt = 65;
            SDef = 75;
            Speed = 119;
        }
    }
}
