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
    public class DrivingRepository : IDrivingRepository
    {
        public List<Driving> GetAllDrivings()
        {
            List<Driving> ListToReturn = new List<Driving>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * from Driving");

            while (sqlDataReader.Read())
            {
                Driving temp = new Driving();

                temp.Id = sqlDataReader.GetInt32(0);
                temp.Mileage = sqlDataReader.GetInt32(1);
                temp.PricePerKM = sqlDataReader.GetDecimal(2);
                temp.TotalEarning = sqlDataReader.GetDecimal(3);
                temp.DispatcherEarning = sqlDataReader.GetDecimal(4);
                temp.DriverID = sqlDataReader.GetInt32(5);

                ListToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return ListToReturn;

        }

        public int InsertDriving(Driving driving)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Driving VALUES ('{0}', '{1}', '{2}' , '{3}','{4}')",
                          driving.Mileage, driving.PricePerKM, driving.TotalEarning, driving.DispatcherEarning, driving.DriverID));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateDriving(Driving driving, int id)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Driving SET Mileage='{0}', PricePerKM ='{1}', TotalEarning ='{2}', DispatcherEarning = '{3}', DriverID = '{4}' Where Id=" + id, driving.Mileage, driving.PricePerKM, driving.TotalEarning, driving.DispatcherEarning, driving.DriverID));

            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteDriving(int drivingID)
        {
            var result = DBConnection.EditData("DELETE FROM Driving WHERE Id=" + drivingID);

            DBConnection.CloseConnection();

            return result;
        }
    }
}
