using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IDriverBusiness
    {
        List<Driver> GetDrivers();
        bool InsertDriver(Driver driver);
        bool UpdateDriver(Driver driver, int id);
        bool DeleteDriver(int driverID);
        List<Driver> GetDriversByDispatcherID(int id);
        Driver GetDriverById(int id);
        Driver GetDriverByNameSurname(String name, String surname);
    }
}
