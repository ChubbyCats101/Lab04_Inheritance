using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Inheritance
{
    public class Pokedex
    {
        protected int Id;
        protected string Name;
        protected Image Pic;
        protected int Level;
        protected PokemonType Type;
        protected PokemonAbilities Abilities;
        protected int Hp;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string getName()
        {
            return Name;
        }
        public Image Picture()
        {
            return Pic;
        }
        public int getId()
        { 
            return Id;
        }
        public int getLevel()
        {
            return Level; 
        }
        public PokemonType getType() 
        { 
            return Type;
        }
        public int getHp() 
        {
            return Hp;
        }
        public int getAtt()
        {
            return Att;
        }
        public int getDef()
        {
            return Def;
        }
        public int getSAtt()
        {
            return SAtt;
        }
        public int getSDef()
        {
            return SDef;
        }
        public int getSpeed()
        {
            return Speed;
        }
    }
    public enum PokemonType
    {
        Dragon, Flying, Electr, normal, Psychc, Fire
    }
    public enum PokemonAbilities
    {
        Air_Lock
    }
}
