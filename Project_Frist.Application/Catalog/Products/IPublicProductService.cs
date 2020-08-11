using Project_Frist.ViewModels.Catalog.Products;
using Project_Frist.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_Frist.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
