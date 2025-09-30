using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[5];
            players[0] = new Player("noe");
            players[1] = new Warrior("gal");
            players[2] = new Wizard("sitbon");
            players[3] = new Warrior("baizer");
            players[4] = new Wizard("sosner");
            for (int i = 0; i < 5; i++)
            {
                if (players[i] is Warrior)
                {
                    for (int j = 0; j < 5; j++)
                        if (players[i] is Wizard)
                            ((Warrior)players[i]).Attack(players[j]);
                }
                if (players[i] is Wizard)
                    ((Wizard)players[i]).Spellpower += 4;
            }





        }
    }
    }
