using System;

namespace SportsCompany.FitnessTracker.Domain
{
    public class Training
    {
        public Training(int count, float average, double trainingEffect, double distance, TimeSpan duration)
        {
            Count = count;
            Average = average;
            TrainingEffect = trainingEffect;
            Distance = distance;
            Duration = duration;
        }

        public int Count { get; }
        public float Average { get; }
        public double TrainingEffect { get; }
        public double Distance { get; }
        public TimeSpan Duration { get; }
    }
}
