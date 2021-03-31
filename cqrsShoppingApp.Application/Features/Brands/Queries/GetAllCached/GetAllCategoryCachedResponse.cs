using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Features.Brands.Queries.GetAllCached
{
    public class GetAllCategoryCachedResponse
    {
        public int ParentId { get; set; } // ParentId
        public string Name { get; set; } // Name
        public bool IsActive { get; set; } // IsActive
        public string Image { get; set; } // Image (length: 100)
    }
}
