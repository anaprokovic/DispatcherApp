using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DriverBusiness : IDriverBusiness
    {
        private readonly IDriverRepository _driverRepository;

        public DriverBusiness(IDriverRepository driverRepository)
        {
            this._driverRepository = driverRepository;
        }
        public List<Driver> GetDrivers()
        {
            return this._driverRepository.GetAllDrivers();
        }
        public bool InsertDriver(Driver driver)
        {
            if (this._driverRepository.InsertDriver(driver) != 0)
                return true;
            return false;
        }
        public bool UpdateDriver(Driver driver, int id)
        {
            if (this._driverRepository.UpdateDriver(driver,id) != 0)
                return true;
            return false;
        }
        public bool DeleteDriver(int driverID)
        {
            if (this._driverRepository.DeleteDriver(driverID) != 0)
                return true;
            return false;
        }
        public List<Driver> GetDriversByDispatcherID(int id)
        {
            return this._driverRepository.GetAllDrivers().Where(driver => driver.DispatcherID == id).ToList();
        }
        public Driver GetDriverById(int id) 
        {
            return this._driverRepository.GetAllDrivers().Where(d => d.Id == id).FirstOrDefault();
        }
        public Driver GetDriverByNameSurname(String name, String surname)
        {
            return this._driverRepository.GetAllDrivers().Where(d => d.Name.Equals(name) && d.Surname.Equals(surname)).FirstOrDefault();
        }
    }
}
