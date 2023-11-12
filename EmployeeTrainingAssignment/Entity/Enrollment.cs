using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.Entity
{
    public class Enrollment
    {
        public string NIC { get; set; }
        public string Email { get; set; }
        public int phoneNum { get; set; }
        public string dept { get; set; }
        public string name { get; set; }
        public string managerName { get; set; }
        public bool pre_Requisite { get; set; } = false;
    }
}
