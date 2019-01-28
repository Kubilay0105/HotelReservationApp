﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        OtelContext ent = new OtelContext();

        public bool AddGuest(Guest g)
        {
            bool Sonuc = false;
            ent.Guests.Add(g);
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

        public List<Guest> GetGuest(int roomId, bool stat)
        {
            throw new NotImplementedException();
        }

        public List<Guest> GetGuest(int RoomId)
        {
            throw new NotImplementedException();
        }

        public int GetGuestIdByTC(string IdentificationNo)
        {
            int GuestId = Convert.ToInt32((from g in ent.Guests
                                          where g.IdentificationNo == IdentificationNo
                                          select g.Id).FirstOrDefault());
            return GuestId;
        }

        public bool UpdateGuest(Guest g)
        {
            throw new NotImplementedException();
        }
    }
}
