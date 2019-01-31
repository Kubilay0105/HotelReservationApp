using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class PersonelRepository : IPersonnelRepository
    {
        OtelContext ent = new OtelContext();
        public bool AddPersonnel(Personnel p)
        {
            bool Sonuc = false;
            ent.Personnel.Add(p);
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
            bool Sonuc = false;
            ent.Personnel.Remove(p);
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

        public bool DeletePersonnel(int ID)
        {
            bool Sonuc = false;
            Personnel silinen = (from p in ent.Personnel
                                where p.Id == ID
                                select p).FirstOrDefault();
            silinen.Status = true;
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

        public List<Personnel> GetPersonnels()
        {
            return ent.Personnel.ToList();
        }

        public bool UpdatePersonnel(Personnel p)
        {
            bool Sonuc = false;
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
        public bool PersonelControl(Personnel p)
        {
            var Personel = (from per in ent.Personnel
                         where per.PersonName == p.PersonName
                         select per).FirstOrDefault();
            if (Personel != null)
                return true;
            return false;
        }
        public Personnel GetPersonelById(int ID)
        {
            Personnel degisen = (from p in ent.Personnel
                                 where p.Id == ID
                                 select p).FirstOrDefault();
            return degisen;
        }
        public bool PersonelControlFromUpdate(Personnel p)
        {
            var personel = (from ext in ent.ExtraTypes
                         where ext.Type == p.PersonName && ext.Id != p.Id
                         select ext).FirstOrDefault();
            if (personel != null)
                return true;
            return false;
        }
    }
}
