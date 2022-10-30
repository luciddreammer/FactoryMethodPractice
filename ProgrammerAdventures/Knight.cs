using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerAdventures
{
    public class Knight : Character
    {
        public override void Initialize()
        {
            profession = "Knight";
            attack = 15;
            defense = 15;
            hp = 150;
            magicAttack = 0;
            mp = 10;
            resist = 15;
        }

        public override int Attack(int enemyResist)
        {
            return this.attack - enemyResist;
        }

        public override void Regeneration()
        {
            this.hp += 10;
        }

        public override Character FactoryMethod()
        {
            var newCharacter = new Knight();
            newCharacter.Initialize();
            return newCharacter;
        }
    }
}
