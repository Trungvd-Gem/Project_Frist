using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
