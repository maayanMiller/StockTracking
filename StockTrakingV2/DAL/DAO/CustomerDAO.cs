using StockTrakingV2.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrakingV2.DAL.DAO
{
    public class CustomerDAO : StockContex, IDAO<CUSTOMER, CustomerDetailDTO>
    {
        public bool Delete(CUSTOMER entity)
        {
            try
            {
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == entity.ID);
                customer.isDeleted = true;
                customer.DeletedDate = DateTime.Today;
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
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == ID);
                customer.isDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Insert(CUSTOMER entity)
        {
            try
            {
                db.CUSTOMERs.Add(entity);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select()
        {
            List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
            var list = db.CUSTOMERs.Where(x => !x.isDeleted);
            foreach (var item in list)
            {
                CustomerDetailDTO customer = new CustomerDetailDTO();
                customer.ID = item.ID;
                customer.CustomerName = item.CustomerName;
                customers.Add(customer);

            }
            return customers;
        }
        public List<CustomerDetailDTO> Select(bool isDeleted)
        {
            List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
            var list = db.CUSTOMERs.Where(x => x.isDeleted);
            foreach (var item in list)
            {
                CustomerDetailDTO customer = new CustomerDetailDTO();
                customer.ID = item.ID;
                customer.CustomerName = item.CustomerName;
                customers.Add(customer);

            }
            return customers;
        }
        public bool Update(CUSTOMER entity)
        {
            try
            {
                CUSTOMER customer = db.CUSTOMERs.First(x => x.ID == entity.ID);
                customer.CustomerName = entity.CustomerName;
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

