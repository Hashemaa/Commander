using Commander.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Commander.Data
{
	public class SqlCommanderRepo(CommanderContext context) : ICommanderRepo
	{
		private readonly CommanderContext _context = context;

		public void CreateCommand(Command command)
		{
			ArgumentNullException.ThrowIfNull(command);

			_context.Add(command);
		}

		public void DeleteCommand(Command command)
		{
			ArgumentNullException.ThrowIfNull(command);

			_context.Remove(command);
		}

		public IEnumerable<Command?> GetAllCommands()
		{
			return _context.Commands.ToList();
		}

		public Command? GetCommandById(int id)
		{
			return _context.Commands.FirstOrDefault(x => x.Id == id);
		}

		public bool SaveChanges()
		{
			return _context.SaveChanges() > 0;
		}

		public void UpdateCommand(Command command)
		{
			//Nothing
		}
	}
}
