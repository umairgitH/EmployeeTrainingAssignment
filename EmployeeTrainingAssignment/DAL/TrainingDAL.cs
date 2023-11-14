using EmployeeTrainingAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.DAL
{
    public class TrainingDAL :  ITrainingDAL
    {
        public TrainingDAL()
        {

        }

        public void Add(TrainingService training)
        {
            //implementation of Add
        }

        public TrainingService Get(int traininId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TrainingService> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TrainingService training)
        {
            //implementation of Remove
        }

        public void Update(TrainingService training)
        {
            //implementation of Update
        }
    }
}
