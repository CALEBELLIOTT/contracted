using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{

  [ApiController]
  [Route("api/contractors")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _cs;

    public ContractorsController(ContractorsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Contractor>> GetAll()
    {
      try
      {
        List<Contractor> contractors = _cs.GetAll();
        return Ok(contractors);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}