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
    public class DispatcherRepository : IDispatcherRepository 
    {
        public List<Dispatcher> GetAllDispatchers()
        {
            List<Dispatcher> listToReturn = new List<Dispatcher>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Dispatcher");

            while (sqlDataReader.Read())
            {
                Dispatcher temp = new Dispatcher();

                temp.Id = sqlDataReader.GetInt32(0);
                temp.Name = sqlDataReader.GetString(1);
                temp.Surname = sqlDataReader.GetString(2);

                listToReturn.Add(temp);
            }

            DBConnection.CloseConnection();

            return listToReturn;
        }

        public int InsertDispatcher(Dispatcher dispatcher)
        {
            int result = DBConnection.EditData(string.Format("INSERT INTO Dispatcher VALUES ('{0}', '{1}')",
                           dispatcher.Name, dispatcher.Surname));

            DBConnection.CloseConnection();

            return result;
        }

        public int UpdateDispatcher(Dispatcher dispatcher)
        {
            int result = DBConnection.EditData(string.Format(
                    "UPDATE Dispatcher SET Name='{0}',Surname='{1}'" +
                    "WHERE Id='" + dispatcher.Id + "'", dispatcher.Name, dispatcher.Surname));

            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteDispatcher(int dispatcherID)
        {
            var result = DBConnection.EditData("DELETE FROM Dispatcher WHERE Id=" + dispatcherID);

            DBConnection.CloseConnection();

            return result;
        }

    }
}
