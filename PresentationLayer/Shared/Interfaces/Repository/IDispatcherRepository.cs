using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IDispatcherRepository
    {
        List<Dispatcher> GetAllDispatchers();
        int InsertDispatcher(Dispatcher dispatcher);
        int UpdateDispatcher(Dispatcher dispatcher);
        int DeleteDispatcher(int dispatcherID);
    }
}
