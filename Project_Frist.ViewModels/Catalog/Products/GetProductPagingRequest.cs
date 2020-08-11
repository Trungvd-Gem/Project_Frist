using Project_Frist.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.ViewModels.Catalog.Products
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
