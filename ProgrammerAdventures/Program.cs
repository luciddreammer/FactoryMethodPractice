using ProgrammerAdventures;

public static class Professions
{
    public const string Druid = "druid";
    public const string Knight = "knight";
}

namespace ProgrammerAdventures
{
    public class Program
    {
        static void Main()
        {
            var creator = new CharacterCreator();
            Console.WriteLine("Choose your class");
            string myClass = Console.ReadLine();
            Character playerCharacter = creator.CharacterCreation(myClass);
            if (myClass == Professions.Druid || myClass == Professions.Knight)
            {
                Console.WriteLine(playerCharacter.profession);
            }
        }
    }
}






