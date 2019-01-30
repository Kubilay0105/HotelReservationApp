using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;
using DAL.Hotel.Model;

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
        
        public Sale GetSaleById(int SaleId)
        {
            return ent.Sales.Where(x=>x.Id==SaleId).Select(x=>x).FirstOrDefault();
        }
        public int GetSalesId(int ID)
        {
            var sonuc = (from s in ent.Sales
                         where s.RoomId == ID
                         select s.Id).FirstOrDefault();
            return sonuc;
        }

        public bool UpdatePersonnel(Personnel p)
        {
            throw new NotImplementedException();
        }
        //Gelen Tarihteki odteldeki satışlar
        public List<SaleModel> SalesIdGetByDate(DateTime Tarih)
        {
            List<SaleModel> Sales = (from s in ent.Sales
                                 where s.CheckIn <= Tarih.Date && s.CheckOut >= Tarih.Date
                                 from g in ent.Guests where g.Id==s.GuestId
                                 select new SaleModel {SaleID=s.Id,FirstName=g.FirstName,LastName=g.LastName,Identification=g.IdentificationNo }).ToList();
            return Sales;
        }
        public bool UpdateSaleStatusForCheckin(int SalesId)
        {
            bool sonuc = false;
            try
            {
                var sonuc1 = (from s in ent.Sales
                              where s.Id == SalesId
                              select s).FirstOrDefault();
                sonuc1.Status = true;
                sonuc = true;
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;

            }
            return sonuc;
        }
    }
}
