using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011A3
{
    internal class Alduin : Minion
    {
        public Alduin(int health, int armour) : base(health, armour)
        {

        }
        public override int DealDamage()
        {
            Random rng = new Random();
            return rng.Next(40, 60);
        }


        //Goblin special
        public Minion Resurrection()
        {
            Console.WriteLine("**SLEN TIID VO**");
            Minion baddie;
            Random rng = new Random();
            int type = rng.Next(0, 2);
            if (type == 0)
            {
                baddie = (new Goblin(rng.Next(30, 35), rng.Next(1, 5), rng.Next(1, 10)));
            }
            else baddie = (new Skellie(rng.Next(25, 31), 0));

            return baddie;
        }
    }
}
