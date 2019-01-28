using System;
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
    }
}
