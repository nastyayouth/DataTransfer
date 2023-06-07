using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Infrastructura.EF;

namespace DataTransfer.Repo
{
    public class DataSetRepo : IDataSetRepo
    {
        private readonly DataContext _dbContext;

        public DataSetRepo(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DataSet>> GetDataSetAsync()
        {
            var res = await  _dbContext.DataSets.ToListAsync();
            return res;
        }
    }
}
