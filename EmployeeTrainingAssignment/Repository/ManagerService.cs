using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.Repository
{
    public class ManagerService : IManagerRepository
    {
        private ManagerService _managerService;
        public ManagerService() { }

        public void ApplicationApproval()
        {
            
        }

        public IEnumerable<ManagerService> GetApplication()
        {
            throw new NotImplementedException();
        }

        public void SendNotification()
        {

        }
    }
}
