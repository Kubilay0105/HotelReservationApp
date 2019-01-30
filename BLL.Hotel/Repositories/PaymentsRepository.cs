using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PaymentsRepository : IPaymentsRepository
    {
        OtelContext ent = new OtelContext();
      
        public List<Payment> GetPayments()
        {
            return ent.Payments.ToList();
        }

        public List<decimal> PaymentsToDate(DateTime Date)
        {
            List<Decimal> payments = new List<decimal>();
            Date = Convert.ToDateTime(Date.ToShortDateString());
            decimal borc = (from g in ent.Payments
                             where g.Status == true && (g.Date < Date)
                             select g.Debt).DefaultIfEmpty(0).Sum();
            payments.Add(borc);
            decimal odenen = (from g in ent.Payments
                            where g.Status == false && (g.Date < Date)
                            select g.Credit).DefaultIfEmpty(0).Sum();
            payments.Add(odenen);
            payments.Add(borc - odenen);//kalan borç
            return payments;

        }
        
        public List<Payment> PaymentsByDate(DateTime Date)
        {
            var payments = (from p in ent.Payments
                            where p.Status == true && p.Date == Date
                            select p).ToList();
            return payments;
        }

        public bool PaymentsAdd(Payment pay)
        {
            bool sonuc = false;
            ent.Payments.Add(pay);
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

        public List<decimal> PaymentTransBySalesId(int SalesId)
        {
            List<Decimal> payments = new List<decimal>();
            decimal borc = (from g in ent.Payments
                            where g.Status == true && g.SalesId == SalesId
                            select g.Debt).DefaultIfEmpty(0).Sum();
            payments.Add(borc);
            decimal odenen = (from g in ent.Payments
                              where g.Status == false && g.SalesId == SalesId
                              select g.Credit).DefaultIfEmpty(0).Sum();
            payments.Add(odenen);
            payments.Add(borc - odenen);//kalan borç
            return payments;
        }
        
    }
}
