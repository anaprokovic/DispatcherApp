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
    public class DispatcherBusiness : IDispatcherBusiness
    {
        private readonly IDispatcherRepository _dispatcherRepository;
        public DispatcherBusiness(IDispatcherRepository dispatcherRepository)
        {
            this._dispatcherRepository = dispatcherRepository;
        }

        public List<Dispatcher> GetAllDispatchers()
        {
            return this._dispatcherRepository.GetAllDispatchers();
        }
        public bool InsertDispatcher(Dispatcher dispatcher)
        {
            if (this._dispatcherRepository.InsertDispatcher(dispatcher) != 0)
                return true;
            return false;
        }
        public bool UpdateDispatcher(Dispatcher dispatcher)
        {
            if(this._dispatcherRepository.UpdateDispatcher(dispatcher) != 0)
                return true;
            return false;
        }
        public bool DeleteDispatcher(int dispatcherID)
        {
            if (this._dispatcherRepository.DeleteDispatcher(dispatcherID) != 0)
                return true;
            return false;
        }
        public bool DispatcherByNameSurname(Dispatcher dispatcher)
        {
            if (this._dispatcherRepository.GetAllDispatchers().Where(d => d.Name.Equals(dispatcher.Name) && d.Surname.Equals(dispatcher.Surname)).FirstOrDefault() != null)
                return true;
            return false;
        }
        public Dispatcher GetDispatcherByNameSurname(String name, String surname)
        {
            return this._dispatcherRepository.GetAllDispatchers().Where(d => d.Name.Equals(name) && d.Surname.Equals(surname)).FirstOrDefault();
        }
        public bool GetDispatcherByID(int id)
        {
            if (this._dispatcherRepository.GetAllDispatchers().Where(d => d.Id == id).FirstOrDefault() != null)
                return true;
            return false;
        }
    }
}
