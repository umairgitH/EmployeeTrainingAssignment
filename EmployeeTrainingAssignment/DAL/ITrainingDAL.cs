using EmployeeTrainingAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.DAL
{
    public interface ITrainingDAL
    {
        void Add(TrainingService training);
        void Remove(TrainingService training);
        void Update(TrainingService training);
        TrainingService Get(int traininId);
        //return a collections of list where we cannot manipulate it compared to list
        // we can manipulate it
        IEnumerable<TrainingService> GetAll();
    }
}
