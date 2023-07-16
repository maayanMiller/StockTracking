using StockTrakingV2.DAL.DAO;
using StockTrakingV2.DAL.DTO;
using StockTrakingV2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.BLL
{
    public class ProductBLL : IBLL<ProductDetailDTO, ProductDTO>
    {
        CategoryDAO catgorydao = new CategoryDAO();
        ProductDAO dao = new ProductDAO();
        SalesDAO salesdao = new SalesDAO(); 
        public bool Delete(ProductDetailDTO entity)
        {
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            dao.Delete(product);
            SALE sale= new SALE();
            sale.ProductID = entity.ProductID;
            salesdao.Delete(sale);  
            return true;

        }

        public bool GetBack(ProductDetailDTO entity)
        {
            dao.GetBack(entity.ProductID);
            return true;
        }

        public bool Insert(ProductDetailDTO entity)
        {
            PRODUCT product = new PRODUCT();
            product.ProductName = entity.ProductName;
            product.Price = entity.Price;
            product.CategoryID = entity.CategoryID;
            return dao.Insert(product);
        }

        public ProductDTO Select()
        {
            ProductDTO dto = new ProductDTO();
            dto.Categories = catgorydao.Select();
            dto.Products = dao.Select();
            return dto;
        }

        public bool Update(ProductDetailDTO entity)
        {

            PRODUCT product = new PRODUCT();
            product.ProductName = entity.ProductName;
            product.Price = entity.Price;
            product.CategoryID = entity.CategoryID;
            product.StockAmount = entity.StockAmount;
            product.ID = entity.ProductID;
            return dao.Update(product);
        }
    }
}
