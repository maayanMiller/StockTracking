using StockTrakingV2.DAL;
using StockTrakingV2.DAL.DAO;
using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockTrakingV2.BLL
{
    public class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        CategoryDAO catgorydao = new CategoryDAO();
        ProductDAO productdao = new ProductDAO();
        CustomerDAO customerdao = new CustomerDAO();
        SalesDAO dao = new SalesDAO();

        public bool Delete(SalesDetailDTO entity)
        {
            SALE sALE = new SALE();
            sALE.ID = entity.SalesID;
            dao.Delete(sALE);
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            product.StockAmount = entity.StockAmount+ entity.SalesAmount;
            productdao.Update(product);
            return true;    
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            dao.GetBack(entity.SalesID);
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            productdao.Update(product);
            return true;
        }

        public bool Insert(SalesDetailDTO entity)
        {
            SALE sales = new SALE();
            sales.ProductID = entity.ProductID;
            sales.CategoryID = entity.CategoryID;
            sales.CustomerID = entity.CustomerID;
            sales.SalesDate = entity.SalesDate;
            sales.ProductSalesAmount = entity.SalesAmount;
            sales.ProductSalesPrice = entity.Price;
          dao.Insert(sales);
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp; 
            productdao.Update(product);
            return true;
        }

        public SalesDTO Select()
        {
           SalesDTO dto = new SalesDTO();
            dto.Customers = customerdao.Select();
            dto.Products = productdao.Select(); 
            dto.Catgories = catgorydao.Select();
            dto.Sales = dao.Select();   
            return dto;
        }
        public SalesDTO Select(bool isDelted)
        {
            SalesDTO dto = new SalesDTO();
            dto.Customers = customerdao.Select(isDelted);
            dto.Products = productdao.Select(isDelted);
            dto.Catgories = catgorydao.Select(isDelted);
            dto.Sales = dao.Select(isDelted);
            return dto;
        }

        public bool Update(SalesDetailDTO entity)
        {
            SALE sALE = new SALE();
            sALE.ID = entity.SalesID;
            sALE.ProductSalesAmount = entity.SalesAmount;
            dao.Update(sALE);
            PRODUCT product = new PRODUCT();
            product.ID = entity.ProductID;
            product.StockAmount = entity.StockAmount;   
            productdao.Update(product);
            return true;    
        }
    }
}
