using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerAdventures
{
    public class CharacterCreator
    {
        public Character CharacterCreation(string myClass)
        {
            Character playerCharacter = null;
            if (myClass == Professions.Druid)
            {
                var druidFactory = new Druid();
                playerCharacter = druidFactory.FactoryMethod();
            }
            else if (myClass == Professions.Knight)
            {
                var knightFactory = new Knight();
                playerCharacter = knightFactory.FactoryMethod();
            }
            
            return playerCharacter;
        }
    }
}
