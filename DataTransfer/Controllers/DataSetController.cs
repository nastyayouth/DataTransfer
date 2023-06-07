using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Query;

namespace DataTransfer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataSetController : Controller
    {

        private readonly IMediator _mediator;

        public DataSetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetDataSets")]
        public async Task<ActionResult<IEnumerable<DataSet>>> GetDataSets()
        {
            return await _mediator.Send(new GetDataSetsQuery());

        }
    }
}
