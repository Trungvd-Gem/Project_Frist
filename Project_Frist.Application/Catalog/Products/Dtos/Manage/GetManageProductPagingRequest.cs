using Project_Frist.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Application.Catalog.Products.Dtos.Manage
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
