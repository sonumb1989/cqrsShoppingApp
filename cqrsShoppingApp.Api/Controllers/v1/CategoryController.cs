using cqrsShoppingApp.API.Controllers;
using cqrsShoppingApp.Application.Features.Brands.Commands.Create;
using cqrsShoppingApp.Application.Features.Brands.Queries.GetAllCached;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Api.Controllers.v1
{
    
    public class CategoryController : BaseApiController<CategoryController>
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await _mediator.Send(new GetAllCategoryCachedQuery());
            return Ok(brands);
        }
    }
}
