using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.Repository
{
    public interface IUserRepository
    {
        void Register();
        void Login();
        void Validation();
    }
}
