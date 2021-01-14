using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IDriverRepository
    {
        List<Driver> GetAllDrivers();
        int InsertDriver(Driver driver);
        int UpdateDriver(Driver driver, int id);
        int DeleteDriver(int driverID);
    }
}
