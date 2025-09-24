using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
	public class CommanderContext(DbContextOptions<CommanderContext> options) : DbContext(options)
	{
		public DbSet<Command> Commands { get; set; }
	}
}
