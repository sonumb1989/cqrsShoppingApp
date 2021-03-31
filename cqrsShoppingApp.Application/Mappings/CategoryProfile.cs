using AutoMapper;
using cqrsShoppingApp.Application.Features.Brands.Commands.Create;
using cqrsShoppingApp.Application.Features.Brands.Queries.GetAllCached;
using cqrsShoppingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Mappings
{
    internal class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            //CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllCategoryCachedResponse, Category>().ReverseMap();
        }
    }
}
