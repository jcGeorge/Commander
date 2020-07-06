using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      //throw new System.NotImplementedException();
      var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Slice Bread", Line="Get a knife", Platform="Cutting board"},
                new Command{Id=2, HowTo="Cup o' Tea", Line="Tea bag in cup", Platform="Kettle & Cup"},
            };
      return commands;
    }

    public Command GetCommandById(int Id)
    {
      //throw new System.NotImplementedException();
      return new Command { Id = Id, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
    }
  }
}