using System.Collections.Generic;
using System.Threading.Tasks;
using DataTransfer.Application.Models;

namespace DataTransfer.Repo
{
    public interface IDataSetRepo 
    {
        public Task<List<DataSet>> GetDataSetAsync();
    }
}
