using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wojownicy
{
    public class Wojownik
    {
        private int HitPoints;
        private int RangedAtt;
        private int RangedDef;
        private int MeleeAtt;
        private int MeleeDef;
        public bool Ranged;
        public int Speed;
        public string Name;
        public Wojownik(int Hitpoints, int RangedAtt, int RangedDef, int MeleeAtt, int MeleeDef, bool Ranged, int Speed, string Name)
        {
            this.HitPoints = Hitpoints;
            this.RangedAtt = RangedAtt;
            this.RangedDef = RangedDef;
            this.MeleeAtt = MeleeAtt;
            this.MeleeDef = MeleeDef;
            this.Ranged = Ranged;
            this.Speed = Speed;
            this.Name = Name;
        }

        public int RollRanged()
        {
            Random roll = new Random();
            return roll.Next(0, this.RangedAtt + 1);
        }
        public int RollRangedDef()
        {
            Random roll = new Random();
            return roll.Next(0, this.RangedDef + 1);
        }
        public int RollMelee()
        {
            Random roll = new Random();
            return roll.Next(0, this.MeleeAtt + 1);
        }
        public int RollMeleeDef()
        {
            Random roll = new Random();
            return roll.Next(0, this.MeleeDef + 1);
        }
        public void TakeDmg(int Damage)
        {
            this.HitPoints -= Damage;
        }
        public bool IsDead()
        {
            if(this.HitPoints>0)
                return true;
            else
                return false;
        }
    }
}
