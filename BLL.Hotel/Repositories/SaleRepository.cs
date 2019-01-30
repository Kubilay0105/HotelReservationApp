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

        public List<ReservationsModel> GetSales(DateTime today)
        {
            List<ReservationsModel> SaleList = (from sl in ent.Sales
                                   where sl.CheckIn >= today.Date && sl.Status == true
                                   select new ReservationsModel { SalesId=sl.Id,GuestId=sl.GuestId,GuestFirstName=sl.Guest.FirstName,GuestLastName=sl.Guest.LastName,GuestIdtf=sl.Guest.IdentificationNo,GuestContactNo=sl.Guest.ContactNo,GuestMail=sl.Guest.Email,CheckIn=sl.CheckIn,CheckOut=sl.CheckOut }).ToList();
            return SaleList;
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
        public bool UpdateSalesByGuestId(int ID)
        {
            bool sonuc = false;
            bool sondeger = (from s in ent.Sales
                             where s.GuestId == ID
                             select s.Status).FirstOrDefault();
            sondeger = false;
            try
            {
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return sonuc;

        }
    }
}
