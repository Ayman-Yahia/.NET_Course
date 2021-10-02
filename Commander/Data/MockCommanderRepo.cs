using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                return new Command { id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Coding dojo" };
                return new Command { id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Axsos" };
                return new Command { id = 2, HowTo = "Boil an tea", Line = "place water", Platform = "Coding dojo" };
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Coding dojo" };
        }
    }

}