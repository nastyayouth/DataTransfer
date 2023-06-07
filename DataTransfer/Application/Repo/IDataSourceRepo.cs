using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;

namespace DataTransfer.Repo
{
    public interface IDataSourceRepo
    {
        public Task<List<DataSource>> GetDataSetAsync();
    }
}
