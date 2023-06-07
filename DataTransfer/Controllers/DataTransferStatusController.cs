using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Infrastructura.EF;

namespace DataTransfer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataTransferStatusController : Controller
    {
        private readonly DataContext _context;
        public DataTransferStatusController(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Получение статуса отправки данных
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetDataTransferStatus")]
        public async Task<ActionResult<IEnumerable<DataTransferStatus>>> GetDataTransferStatus()
        {
            return await _context.DataTransferStatuses.ToListAsync();

        }
    }
}
