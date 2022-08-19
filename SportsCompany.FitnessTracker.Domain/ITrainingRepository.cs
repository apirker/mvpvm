using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCompany.FitnessTracker.Domain
{
    public interface ITrainingRepository
    {
        void Add(Training training);
        IList<Training> GetAll();
    }
}
