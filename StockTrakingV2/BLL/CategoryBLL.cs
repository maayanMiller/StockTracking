using StockTrakingV2.DAL;
using StockTrakingV2.DAL.DAO;
using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.BLL
{
    public class CategoryBLL : IBLL<CategoryDetailDTO, CategoryDTO>
    {
        CategoryDAO dao = new CategoryDAO();
        ProductDAO Productdao = new ProductDAO();
        public bool Delete(CategoryDetailDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.ID = entity.ID;
            dao.Delete(category);
            PRODUCT product = new PRODUCT();
            product.CategoryID = entity.ID;
            Productdao.Delete(product);
            return true;
        }

        public bool GetBack(CategoryDetailDTO entity)
        {
            dao.GetBack(entity.ID);
            return true;    
        }

        public bool Insert(CategoryDetailDTO entity)
        {

            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            return dao.Insert(category);
        }

        public CategoryDTO Select()
        {
            CategoryDTO dto = new CategoryDTO();
            dto.Catgories = dao.Select();
            return dto;

        }

        public bool Update(CategoryDetailDTO entity)
        {
            CATEGORY category = new CATEGORY();
            category.CategoryName = entity.CategoryName;
            category.ID = entity.ID;
            return dao.Update(category);
        }
    }
}
