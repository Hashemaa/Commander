using Commander.Models;

namespace Commander.Data
{
	public class MockCommanderRepo : ICommanderRepo
	{
		public void CreateCommand(Command command)
		{
			throw new NotImplementedException();
		}

		public void DeleteCommand(Command command)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Command?> GetAllCommands()
		{
			var commands = new List<Command> {
				new Command {Id = 0, HowTo = "The first mock HowTo", Line = "The first mock Line", Platform = "The first mcok Platform"},
				new Command {Id = 1, HowTo = "The second mock HowTo", Line = "The second mock Line", Platform = "The second mcok Platform"},
				new Command {Id = 2, HowTo = "The third mock HowTo", Line = "The third mock Line", Platform = "The third mcok Platform"},
			};

			return commands;
		}

		public Command? GetCommandById(int id)
		{
			return new Command { Id = 0, HowTo = "Mock by id HowTo", Line = "Mock by id Line", Platform = "Mock by id Platform"};
		}

		public bool SaveChanges()
		{
			throw new NotImplementedException();
		}

		public void UpdateCommand(Command command)
		{
			throw new NotImplementedException();
		}
	}
}
