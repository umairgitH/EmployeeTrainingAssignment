using EmployeeTrainingAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingAssignment.Repository
{
    public class TrainingService : ITrainingRepository
    {
        private readonly ITrainingDAL _training;
        public TrainingService(ITrainingDAL training)
        {
            _training = training;
        }

        public void Add(TrainingService training)
        {
            _training.Add(training);
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
            _training.Remove(training);
        }

        public void Update(TrainingService training)
        {
            _training.Update(training);
        }
    }
}
