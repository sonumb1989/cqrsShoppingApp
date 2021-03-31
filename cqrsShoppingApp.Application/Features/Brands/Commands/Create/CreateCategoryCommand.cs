using AspNetCoreHero.Results;
using AutoMapper;
using cqrsShoppingApp.Application.Interfaces.Repositories;
using cqrsShoppingApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Features.Brands.Commands.Create
{
    public partial class CreateCategoryCommand: IRequest<Result<int>>
    {
        public int ParentId { get; set; } 
        public string Name { get; set; } 
        public string Image { get; set; } 
    }

    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Result<int>>
    {
        private readonly IRepositoryAsync<Category> _brandRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork { get; set; }

        public CreateCategoryCommandHandler(IRepositoryAsync<Category> brandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Category>(request);
            await _brandRepository.AddAsync(product);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(product.Id);
        }
    }
}
