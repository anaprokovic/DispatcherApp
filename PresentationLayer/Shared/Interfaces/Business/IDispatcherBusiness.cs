using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IDispatcherBusiness
    {
        List<Dispatcher> GetAllDispatchers();
        bool InsertDispatcher(Dispatcher dispatcher);
        bool UpdateDispatcher(Dispatcher dispatcher);
        bool DeleteDispatcher(int dispatcherID);
        bool DispatcherByNameSurname(Dispatcher dispatcher);
        bool GetDispatcherByID(int id);
        Dispatcher GetDispatcherByNameSurname(String name, String surname);
    }
}
