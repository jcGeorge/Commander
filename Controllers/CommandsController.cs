using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  // //api/commands (this is a 'wild card' approach)
  // [Route("api/[controller]")]
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepo _repository;

    public CommandsController(ICommanderRepo repository)
    {
      _repository = repository;
    }
    //private readonly ICommanderRepo _repository = new MockCommanderRepo();
    //GET api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      //throw new System.NotImplementedException();
      var commandItems = _repository.GetAppCommands();
      return Ok(commandItems);
    }

    //GET api/commands/5
    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      //throw new System.NotImplementedException();
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}