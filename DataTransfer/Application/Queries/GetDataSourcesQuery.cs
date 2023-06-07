using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DataTransfer.Application.Models;
using DataTransfer.Repo;

namespace DataTransfer.Query
{
    public class GetDataSourcesQuery : IRequest<List<DataSource>>
    {
    }
    public class GetDataSourceQueryHandler : IRequestHandler<GetDataSourcesQuery, List<DataSource>>
    {
        private readonly IDataSourceRepo _datasource;
        public GetDataSourceQueryHandler(IDataSourceRepo datasource, IMediator mediator)
        {
            _datasource = datasource;
        }
        public async Task<List<DataSource>> Handle(GetDataSourcesQuery query, CancellationToken cancellationToken)
        {
            return await _datasource.GetDataSetAsync();
        }
    }
}
