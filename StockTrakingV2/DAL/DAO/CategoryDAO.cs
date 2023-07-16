using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.DAL.DAO
{
    public class CategoryDAO : StockContex, IDAO<CATEGORY, CategoryDetailDTO>
    {
        public bool Delete(CATEGORY entity)
        {
            try
            {
                CATEGORY category = db.CATEGORies.First(x => x.ID == entity.ID);
                category.isDeleted = true;
                category.DeletedDate = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                CATEGORY category = db.CATEGORies.First(x => x.ID ==ID);
                category.isDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Insert(CATEGORY entity)
        {
            try
            {
                db.CATEGORies.Add(entity);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select()
        {
            try
            {
                List<CategoryDetailDTO> category = new List<CategoryDetailDTO>();
                var list = db.CATEGORies.Where(x => !x.isDeleted);
                foreach (var item in list)
                {
                    CategoryDetailDTO dto = new CategoryDetailDTO();
                    dto.ID = item.ID;
                    dto.CategoryName = item.CategoryName;
                    category.Add(dto);

                }
                return category;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<CategoryDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<CategoryDetailDTO> category = new List<CategoryDetailDTO>();
                var list = db.CATEGORies.Where(x => x.isDeleted);
                foreach (var item in list)
                {
                    CategoryDetailDTO dto = new CategoryDetailDTO();
                    dto.ID = item.ID;
                    dto.CategoryName = item.CategoryName;
                    category.Add(dto);

                }
                return category;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(CATEGORY entity)
        {
            try
            {
                CATEGORY category = db.CATEGORies.First(x => x.ID == entity.ID);
                category.CategoryName = entity.CategoryName;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
