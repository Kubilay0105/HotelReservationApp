﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Hotel.Context;

namespace BLL.Hotel.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        OtelContext ent = new OtelContext();
        public int GetRoomId(string RoomNo)
        {
            int sonuc = (from r in ent.Rooms
                         where r.RoomNumber == RoomNo
                         select r.Id).FirstOrDefault();
            return sonuc;
        }
        public string GetRoomNo(int Id)
        {
            string sonuc = (from r in ent.Rooms
                         where r.Id == Id
                         select r.RoomNumber).FirstOrDefault();
            return sonuc;
        }
        public decimal GetRoomPrice(string RoomNo)
        {
            decimal sonuc = (from r in ent.Rooms
                             from rt in ent.RoomType
                             where r.RoomNumber == RoomNo
                             where r.RoomTypeId == rt.Id
                             select rt.Price).FirstOrDefault();
            return sonuc;
        }
        public List<Room> GetRooms()
        {
            return ent.Rooms.ToList();
        }
        public int FullRoomsCount()
        {
            int DoluSayi=(from s in ent.Sales
                         where s.Status==true
                         select s).Count();
            return DoluSayi;
        }
        //ıd ye göre oda o getiren sorgu yaz
        public Room GetRoom(int Rid)
        {
            return ent.Rooms.Where(x => x.Id == Rid).Select(x => x).FirstOrDefault();
        }
        public bool UpdateRoomByRoomNo(string RoomNum)
        {
            bool sonuc = false;
            bool sondeger = (from s in ent.Rooms
                             where s.RoomNumber == RoomNum
                             select s.State).FirstOrDefault();
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
