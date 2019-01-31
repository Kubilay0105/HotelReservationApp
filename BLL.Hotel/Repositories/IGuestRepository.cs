using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IGuestRepository
    {
        List<Guest> GetAllGuest();
        List<Guest> GetGuest(int roomId, bool stat);
        List<Guest> GetAllGuestByStatus();
        List<Guest> GetGuest(int RoomId);
        Guest GetGuestByTC(string TC);
        bool AddGuest(Guest g);
        bool UpdateGuest(Guest g);
        int GetGuestIdByTC(string IdentificationNo);
        bool UpdateGuestStatusForCheckin(int Id);
        List<Guest> GetGuestBySearch(string Ad, string Soyad, string Tc);
    }
}
