using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerAdventures
{
    public abstract class Character
    {
        public string gender;
        public string profession;
        public string name;

        public int attack;
        public int defense;
        public int hp;
        public int magicAttack;
        public int mp;
        public int resist;

        public abstract void Initialize();

        public abstract void Regeneration();

        public abstract int Attack(int enemyResist);

        public abstract Character FactoryMethod();

    }
}
