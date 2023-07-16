using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.DAL.DTO
{
    public class SalesDTO
    {
        public List<CustomerDetailDTO> Customers { get; set; }
        public List<ProductDetailDTO> Products { get; set; }
        public List<CategoryDetailDTO> Catgories { get; set; }
        public List<SalesDetailDTO> Sales { get; set; }
    }
}
