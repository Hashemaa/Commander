using Commander.Models;

namespace Commander.Data
{
	public class SqlCommanderRepo(CommanderContext context) : ICommanderRepo
	{
		private readonly CommanderContext _context = context;
		public IEnumerable<Command?> GetAllCommands()
		{
			return _context.Commands.ToList();
		}

		public Command? GetCommandById(int id)
		{
			return _context.Commands.FirstOrDefault(x => x.Id == id);
		}
	}
}
