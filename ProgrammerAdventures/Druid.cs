using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerAdventures
{
    public class Druid : Character
    {
        public override void Initialize()
        {
            profession = "Druid";
            attack = 5;
            defense = 5;
            hp = 50;
            magicAttack = 10;
            mp = 100;
            resist = 5;
        }
        public override int Attack(int enemyResist)
        {
            return this.magicAttack - enemyResist;
        }

        public override void Regeneration()
        {
            this.hp += 20;
        }

        public override Character FactoryMethod()
        {
            var newCharacter = new Druid();
            newCharacter.Initialize();
            return newCharacter;
        }
    }
}
