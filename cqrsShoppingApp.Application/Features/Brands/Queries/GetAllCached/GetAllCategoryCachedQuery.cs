using AspNetCoreHero.Results;
using AutoMapper;
using cqrsShoppingApp.Application.Interfaces.CacheRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Features.Brands.Queries.GetAllCached
{
    public class GetAllCategoryCachedQuery : IRequest<Result<List<GetAllCategoryCachedResponse>>>
    {
        public GetAllCategoryCachedQuery()
        {
        }
    }

    public class GetAllCategoryCachedQueryHandler : IRequestHandler<GetAllCategoryCachedQuery, Result<List<GetAllCategoryCachedResponse>>>
    {
        private readonly ICategoryCacheRepository _categoryCache;
        private readonly IMapper _mapper;

        public GetAllCategoryCachedQueryHandler(ICategoryCacheRepository categoryCache, IMapper mapper)
        {
            _categoryCache = categoryCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllCategoryCachedResponse>>> Handle(GetAllCategoryCachedQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _categoryCache.GetCachedListAsync();
            var result = _mapper.Map<List<GetAllCategoryCachedResponse>>(categoryList);

            return Result<List<GetAllCategoryCachedResponse>>.Success(result);
        }
    }
}
