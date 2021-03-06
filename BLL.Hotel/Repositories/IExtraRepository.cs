﻿using DAL.Hotel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Hotel.Repositories
{
    public interface IExtraRepository
    {
        bool AddExtraTrans(ExtraTransactions Ex);
        List<ExtraTransactions> GetExtras(int RoomId);
        ExtraType GetExtraType(int TypeName);

    }
}
