﻿using System;

namespace Myspace
{
    internal class Warrior : Hero
    {
        public bool crit = false;
        public Warrior(string Name, double Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
            crit = false;
        }

        public double Attack(double AttackPower, Attack typeAttack)
        {

            double totallDamage = AttackPower;

            
            if (CriticalChance() > 80)
            {          
                return 0;
            }
            crit = false;
            if (CriticalChance() > 50)
            {
                crit = true;
                totallDamage *= 1.5;
            }


            if (typeAttack == Myspace.Attack.Physical)
            {
                totallDamage -= ResistanceToPhysical;
            }
            else
            {
                totallDamage -= ResistanceToMagical;
            }
            

            return totallDamage;
        }


        private int CriticalChance()
        {
            Random random = new Random();
            int rand = random.Next(1, 101);
            return rand;
        }
    }
}