using Application.Cushions.Queries;
using Application.Cushions.Queries.ListCushion;
using Application.Cushions.Queries.SingleCushion;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class CushionsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<CushionDto>>> GetCushionsList()
        {
            return Ok(await Mediator.Send(new ListCushionQuery()));
        }

        [HttpGet("{stand}/{position}")]
        public async Task<ActionResult<CushionDto>> GetCushionSingle(int stand, string position)
        {
            var rollPosition = (RollPosition)Enum.Parse(typeof(RollPosition), position, true);
            return Ok(await Mediator.Send(new SingleCushionQuery(stand, rollPosition)));
        }
    }
}
