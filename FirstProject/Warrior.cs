using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Warrior : Player
    {
        public bool hasSword
        {
            get; private set;
        }
        public bool hasShield
        {
            get; private set;
        }
        public override void Attack(Player p2)
        {
            if (hasSword)
            {
                Console.WriteLine("swish swash");
                p2.hp -= 2;
            }
            else
            {
                base.Attack(p2);
            }
        }
        public Warrior(string name) : base(name)
        {
            hasSword = true;
            hasShield = true;
        }




    }
}
