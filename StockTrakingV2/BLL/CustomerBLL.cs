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
    public class CustomerBLL : IBLL<CustomerDetailDTO, CustomerDTO>
    {
        CustomerDAO dao = new CustomerDAO();
        SalesDAO salesdao = new SalesDAO();

        public bool Delete(CustomerDetailDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.ID = entity.ID;    
            dao.Delete(customer);   
            SALE sale = new SALE();
            sale.CustomerID = entity.ID;
            salesdao.Delete(sale);
            return true;
        }

        public bool GetBack(CustomerDetailDTO entity)
        {
            dao.GetBack(entity.ID);
            return true;
        }

        public bool Insert(CustomerDetailDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.CustomerName = entity.CustomerName;
            return dao.Insert(customer);
        }

        public CustomerDTO Select()
        {
            CustomerDTO dto = new CustomerDTO();
            dto.Customers = dao.Select();
            return dto;
        }

        public bool Update(CustomerDetailDTO entity)
        {
            CUSTOMER customer = new CUSTOMER();
            customer.CustomerName = entity.CustomerName;
           customer.ID = entity.ID;
            return dao.Update(customer);
        }
    }
}
