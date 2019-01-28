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
        List<Guest> GetGuest(int roomId, bool stat);
        List<Guest> GetGuest(int RoomId);
        bool AddGuest(Guest g);
        bool UpdateGuest(Guest g);
    }
}
