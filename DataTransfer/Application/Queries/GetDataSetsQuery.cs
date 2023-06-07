using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Repo;

namespace DataTransfer.Query
{
    public class GetDataSetsQuery : IRequest<List<DataSet>>
    {
    }
    public class GetDataSetsQueryHandler : IRequestHandler<GetDataSetsQuery, List<DataSet>>
    {
        private readonly IDataSetRepo _dataRepo;
        public GetDataSetsQueryHandler(IDataSetRepo dataContext, IMediator mediator)
        {
            _dataRepo = dataContext;
        }
        public async Task<List<DataSet>> Handle(GetDataSetsQuery query, CancellationToken cancellationToken)
        {
            return await _dataRepo.GetDataSetAsync();
        }
    }
}
