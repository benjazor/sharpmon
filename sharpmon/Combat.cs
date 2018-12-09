using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Combat
    {
        private Player Attacker;
        public Player GetAttacker()
        {
            return this.Attacker;
        }
        public void SetAttacker(Player player)
        {
            this.Attacker = player;
        }

        private Sharpmon Enemy;
        public Sharpmon GetEnemy()
        {
            return this.Enemy;
        }
        public void SetEnemy(Sharpmon enemy)
        {
            this.Enemy = enemy;
        }

        private Sharpmon HighestSpeed(Sharpmon sharpmon1, Sharpmon sharpmon2)
        {
            if (sharpmon1.getSpeed() == sharpmon2.getSpeed())
            {
                Random random = new Random();
                if (random.Next(100) < 50)
                {
                    return sharpmon1;
                }
                else
                {
                    return sharpmon2;
                }
            }
            else if (sharpmon1.getSpeed() > sharpmon2.getSpeed())
            {
                return sharpmon1;
            }
            else
            {
                return sharpmon2;
            }
        }

        private bool Turn(Sharpmon attacker, Sharpmon enemy)
        {

            return true;
        }
    }
}
