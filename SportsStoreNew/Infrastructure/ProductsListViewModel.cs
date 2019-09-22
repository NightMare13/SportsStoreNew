using System.Collections.Generic;
using SportsStoreNew.Models;
using SportsStoreNew.Models.ViewModels;

namespace SportsStoreNew.Infrastructure
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
