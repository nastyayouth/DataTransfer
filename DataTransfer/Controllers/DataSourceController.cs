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
    public class DataSourceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DataSourceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Получение  данных  всех источников
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetDataSource")]
        public async Task<ActionResult<IEnumerable<DataSource>>> GetDataSource()
        {
            return await _mediator.Send(new GetDataSourcesQuery());
        }
      
    }
}
