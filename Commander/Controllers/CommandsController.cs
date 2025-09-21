using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
	[Route("api/commands")] //or [Route("api/[controller]")]
	[ApiController]
	public class CommandsController : ControllerBase //ControllerBase = without view support
	{
		//private readonly MockCommanderRepo _repository = new MockCommanderRepo();
		private readonly ICommanderRepo _repository;

		public CommandsController(ICommanderRepo repository) {
			_repository = repository;
		}

		//GET api/commands
		[HttpGet]
		public ActionResult<IEnumerable<Command>> GetAllCommands()
		{
			var commandItems = _repository.GetAllCommands();
			return Ok(commandItems);
		}

		//GET api/commands/5
		[HttpGet("{id}")]
		public ActionResult<Command> GetCommandById(int id)
		{
			var commandItem = _repository.GetCommandById(id);
			return Ok(commandItem);
		}
	}
}
