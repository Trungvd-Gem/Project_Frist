using Project_Frist.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
