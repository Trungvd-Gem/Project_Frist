using Project_Frist.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
