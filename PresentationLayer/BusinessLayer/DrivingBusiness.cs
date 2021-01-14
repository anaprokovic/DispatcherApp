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
    public class DrivingBusiness : IDrivingBusiness
    {
        private readonly IDrivingRepository _drivingRepository;

        public DrivingBusiness(IDrivingRepository drivingRepository)
        {
            this._drivingRepository = drivingRepository;
        }
        public List<Driving> GetDrivings()
        {
            return this._drivingRepository.GetAllDrivings();
        }
        public bool InsertDriving(Driving driving)
        {
            if (this._drivingRepository.InsertDriving(driving) != 0)
                return true;
            return false;
        }
        public bool UpdateDriving(Driving driving, int id)
        {
            if (this._drivingRepository.UpdateDriving(driving,id) != 0)
                return true;
            return false;
        }
        public bool DeleteDriving(int drivingID)
        {
            if (this._drivingRepository.DeleteDriving(drivingID) != 0)
                return true;
            return false;
        }
        public List<Driving> GetDrivingsByDriverId(int id)
        {
            return this._drivingRepository.GetAllDrivings().Where(d => d.DriverID == id).ToList();
        }
        public Driving GetDrivingsById(int id)
        {
            return this._drivingRepository.GetAllDrivings().Where(d => d.Id == id).FirstOrDefault();
        }
    }
}
