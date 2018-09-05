using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AbstractHero
    {
        private int health;

        public int countMagic = 2;
        public int countSpecialSkill = 1;

        private Magic magic;
        private Hit hit;
        private SpecialSkill skill;

        public Magic Magic { get { return magic; } }
        public Hit Hit { get { return hit; } }
        public SpecialSkill SpecialSkill { get { return skill; } }

        public AbstractHero(AbstractHeroFactory factory)
        {
            this.health = 3;

            magic = factory.CreateMagic();
            hit = factory.CreateHit();
            skill = factory.CreateSpecialSkill();
        }

        public void GetDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
                throw new Exception("Hero is dead");
        }

        public override string ToString()
        {
            return "Health: " + health + "\n" + Hit.ToString() + Magic.ToString() + SpecialSkill.ToString();
        }
    }
}
