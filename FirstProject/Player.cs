using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Player
    {
       public string Name {  get; set; }
        public int hp { get; set; }
        public int strength {  get; set; }

        public Player(string name) {  
            this.Name = name;
            hp = 10;
            strength = 100;
        }

        public virtual void Attack(Player p2)
        {
            Console.WriteLine("Hee Yaa");
            p2.hp -= 1;
        }

    }
}
