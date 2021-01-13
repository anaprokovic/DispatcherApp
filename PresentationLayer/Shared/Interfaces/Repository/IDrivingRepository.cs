using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IDrivingRepository
    {
        List<Driving> GetAllDrivings();
        int InsertDriving(Driving driving);
        int UpdateDriving(Driving driving, int id);
        int DeleteDriving(int drivingID);
    }
}
