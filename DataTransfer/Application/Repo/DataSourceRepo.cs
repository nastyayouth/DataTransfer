using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Infrastructura.EF;

namespace DataTransfer.Repo
{
    public class DataSourceRepo : IDataSourceRepo
    {
        private readonly DataContext _dbContext;

        public DataSourceRepo(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DataSource>> GetDataSetAsync()
        {
            return await  _dbContext.DataSources.ToListAsync();

        }
    }
}
