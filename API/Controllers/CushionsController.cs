using Application.Cushions.Queries;
using Application.Cushions.Queries.ListCushion;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{

    public class CushionsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<CushionDto>>> GetList()
        {
            return Ok(await Mediator.Send(new ListCushionQuery()));
        }
    }
}
