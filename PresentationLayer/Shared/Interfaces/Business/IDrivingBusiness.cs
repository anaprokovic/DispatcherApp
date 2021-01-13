using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IDrivingBusiness
    {
        List<Driving> GetDrivings();
        bool InsertDriving(Driving driving);
        bool UpdateDriving(Driving driving, int id);
        bool DeleteDriving(int drivingID);
        List<Driving> GetDrivingsByDriverId(int id);
        Driving GetDrivingsById(int id);
    }
}
