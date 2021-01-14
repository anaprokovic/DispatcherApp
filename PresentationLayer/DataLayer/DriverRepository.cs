using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DriverRepository : IDriverRepository
    {
        public List<Driver> GetAllDrivers()
        {
            List<Driver> ListToReturn = new List<Driver>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * from Driver");

            while (sqlDataReader.Read())
            {
                Driver temp = new Driver();

                temp.Id = sqlDataReader.GetInt32(0);
                temp.Name = sqlDataReader.GetString(1);
                temp.Surname = sqlDataReader.GetString(2);
                temp.PhoneNumber = sqlDataReader.GetString(3);
                temp.DispatcherID = sqlDataReader.GetInt32(4);

                ListToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return ListToReturn;

        }

        public int InsertDriver(Driver driver)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Driver VALUES ('{0}', '{1}', '{2}' , '{3}')",
                          driver.Name, driver.Surname, driver.PhoneNumber, driver.DispatcherID));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateDriver(Driver driver, int id)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Driver SET Name='{0}', Surname ='{1}', PhoneNumber ='{2}', DispatcherID = '{3}' Where Id=" + id, driver.Name, driver.Surname, driver.PhoneNumber, driver.DispatcherID));

            DBConnection.CloseConnection();

            return result;
        }
        public int DeleteDriver(int driverID)
        {
            var result = DBConnection.EditData("DELETE FROM Driver WHERE Id=" + driverID);

            DBConnection.CloseConnection();

            return result;
        }
    }
}
