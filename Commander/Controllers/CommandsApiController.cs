using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Commander.Controllers
{
	[Route("api/commands")] //or [Route("api/[controller]")]
	[ApiController]
	public class CommandsApiController(ICommanderRepo repository) : ControllerBase //ControllerBase = without view support
	{
		//private readonly MockCommanderRepo _repository = new MockCommanderRepo();
		private readonly ICommanderRepo _repository = repository;

		//public CommandsController(ICommanderRepo repository) {
		//	_repository = repository;
		//}

		//GET api/commands
		[HttpGet]
		public ActionResult<IEnumerable<Command?>> GetAllCommands()
		{
			var commandItems = _repository.GetAllCommands();
			if (!commandItems.IsNullOrEmpty())
			{
				return Ok(commandItems);
			}
			return NotFound(commandItems);
		}

		//GET api/commands/5
		[HttpGet("{id}")]
		public ActionResult<Command?> GetCommandById(int id)
		{
			var commandItem = _repository.GetCommandById(id);
			if (commandItem != null)
			{
				return Ok(commandItem);
			}
			return NotFound(commandItem);
		}
	}
}
