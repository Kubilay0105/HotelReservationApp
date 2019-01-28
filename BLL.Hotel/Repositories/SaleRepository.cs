using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class SaleRepository : ISalesRepository
    {
        OtelContext ent = new OtelContext();

        public bool AddSales(Sale s)
        {
            bool Sonuc = false;
            ent.Sales.Add(s);
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool DeletePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonnel(int ID)
        {
            throw new NotImplementedException();
        }

        public int GetSaleIdByGuest(int GuestId)
        {
            int SaleId = Convert.ToInt32((from s in ent.Sales
                                          where s.GuestId==GuestId
                                          select s.Id).FirstOrDefault());
            return SaleId;
        }

        public List<Sale> GetSales()
        {
            return ent.Sales.ToList();
        }

        public bool UpdatePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }
    }
}
