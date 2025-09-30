using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Wizard: Player
    {
        private int spellpower;
        public int Spellpower
        {
            get { return spellpower; }
            set
            {
                if(value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException("spell power must be more than zero and less than 10");
                spellpower = value;
            }
        }
        public void Castspell(Player p3)
        {
            Console.WriteLine("AbaCadabra");
            p3.strength -= spellpower;
        }
        public override void Attack(Player p2)
        {
          Castspell(p2);
        }
        public Wizard(string name) : base(name)
        {
            spellpower = 1;
        }
        
        
    }
}
