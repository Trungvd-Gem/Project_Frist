using Project_Frist.Application.Catalog.Products.Dtos;
using Project_Frist.Application.Catalog.Products.Dtos.Public;
using Project_Frist.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project_Frist.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
