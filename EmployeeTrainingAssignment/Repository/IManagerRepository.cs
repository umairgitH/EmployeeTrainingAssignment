using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.Repository
{
    public interface IManagerRepository
    {
        IEnumerable<ManagerService> GetApplication();
        void ApplicationApproval();
        void SendNotification();
    }
}
