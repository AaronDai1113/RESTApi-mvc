using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCpmmands()
        {
            var commands=new List<Command>{
                new Command{Id=0,HowTo="Boil an egg",Line="boil water",Platform="Kettle & Pan"},
                new Command{Id=1,HowTo="Cut bread",Line="get a knif",Platform="Knif & Chopping board"},
                new Command{Id=2,HowTo="Make cup of tea",Line="place teabag in tea",Platform="Kettle & Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil an egg",Line="boil water",Platform="Kettle & Pan"};
        }
    }
}