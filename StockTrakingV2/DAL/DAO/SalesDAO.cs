using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.DAL.DAO
{
    internal class SalesDAO : StockContex, IDAO<SALE, SalesDetailDTO>
    {
        public bool Delete(SALE entity)
        {
            try
            {
                if (entity.ID != 0)
                {
                    SALE sale = db.SALES.First(x => x.ID == entity.ID);
                    sale.isDeleted = true;
                    sale.DeletedDate = DateTime.Today;
                    db.SaveChanges();
                }
                else if (entity.ProductID != 0)
                {
                    List<SALE> list = db.SALES.Where(x => x.ProductID == entity.ProductID).ToList();
                    foreach (var item in list)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                    db.SaveChanges();

                }
                else if (entity.CustomerID != 0)
                {
                    List<SALE> list = db.SALES.Where(x => x.CustomerID == entity.CustomerID).ToList();
                    foreach (var item in list)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                SALE customer = db.SALES.First(x => x.ID == ID);
                customer.isDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Insert(SALE entity)
        {
            try
            {
                db.SALES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SalesDetailDTO> Select()
        {
            try
            {
                List<SalesDetailDTO> sales = new List<SalesDetailDTO>();
                var list = (from s in db.SALES.Where(x => !x.isDeleted)
                            join p in db.PRODUCTs on s.ProductID equals p.ID
                            join c in db.CATEGORies on s.CategoryID equals c.ID
                            join cus in db.CUSTOMERs on s.CustomerID equals cus.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName = c.CategoryName,
                                customerName = cus.CustomerName,
                                productID = s.ProductID,
                                categoryID = s.CategoryID,
                                customerID = s.CustomerID,
                                SalesID = s.ID,
                                salesPrice = s.ProductSalesPrice,
                                salesAmount = s.ProductSalesAmount,
                                saleDate = s.SalesDate
                            }).OrderBy(x => x.saleDate).ToList();
                foreach (var item in list)
                {
                    SalesDetailDTO dto = new SalesDetailDTO();
                    dto.ProductName = item.productName;
                    dto.CustomerName = item.customerName;
                    dto.CategoryName = item.categoryName;
                    dto.ProductID = item.productID;
                    dto.CustomerID = item.customerID;
                    dto.SalesID = item.SalesID;
                    dto.CategoryID = item.categoryID;
                    dto.SalesAmount = item.salesAmount;
                    dto.Price = item.salesPrice;
                    dto.SalesDate = item.saleDate;
                    sales.Add(dto);
                }
                return sales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SalesDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<SalesDetailDTO> sales = new List<SalesDetailDTO>();
                var list = (from s in db.SALES.Where(x => x.isDeleted)
                            join p in db.PRODUCTs on s.ProductID equals p.ID
                            join c in db.CATEGORies on s.CategoryID equals c.ID
                            join cus in db.CUSTOMERs on s.CustomerID equals cus.ID
                            select new
                            {
                                productName = p.ProductName,
                                categoryName = c.CategoryName,
                                customerName = cus.CustomerName,
                                productID = s.ProductID,
                                categoryID = s.CategoryID,
                                customerID = s.CustomerID,
                                SalesID = s.ID,
                                salesPrice = s.ProductSalesPrice,
                                salesAmount = s.ProductSalesAmount,
                                saleDate = s.SalesDate
                            }).OrderBy(x => x.saleDate).ToList();
                foreach (var item in list)
                {
                    SalesDetailDTO dto = new SalesDetailDTO();
                    dto.ProductName = item.productName;
                    dto.CustomerName = item.customerName;
                    dto.CategoryName = item.categoryName;
                    dto.ProductID = item.productID;
                    dto.CustomerID = item.customerID;
                    dto.SalesID = item.SalesID;
                    dto.CategoryID = item.categoryID;
                    dto.SalesAmount = item.salesAmount;
                    dto.Price = item.salesPrice;
                    dto.SalesDate = item.saleDate;
                    sales.Add(dto);
                }
                return sales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(SALE entity)
        {
            try
            {
                SALE sale = db.SALES.First(x => x.ID == entity.ID);
                sale.ProductSalesAmount = entity.ProductSalesAmount;
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
