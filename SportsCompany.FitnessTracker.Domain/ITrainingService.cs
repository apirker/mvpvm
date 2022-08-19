using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCompany.FitnessTracker.Domain
{
    public interface ITrainingService
    {
        void StartTraining();
        Training StopTraining();
        void SaveTraining();
    }
}
