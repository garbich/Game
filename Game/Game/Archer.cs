﻿using System;

namespace Myspace
{
    internal class Archer : Hero
    {
        public Archer(string Name, double Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
        }

        public double Attack(double AttackPower, Attack typeAttack)
        {

            double totallDamage = AttackPower;



            if (CriticalChance() > 80)
            {
              
                return 0;
            }


            if (typeAttack == Myspace.Attack.Physical)
            {

                totallDamage -= ResistanceToPhysical;
                if (CriticalChance() > 50)
                {
                    
                    totallDamage *= 1.5;
                }
            }
            else
            {

                totallDamage -= ResistanceToMagical;
                if (CriticalChance() > 50)
                {
                  
                    totallDamage *= 1.5;
                }
            }
        

            return totallDamage;
        }
        public int CriticalChance()
        {
            Random random = new Random();
            int rand = random.Next(1, 101);
            return rand;
        }
    }
}