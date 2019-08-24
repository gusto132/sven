using System;

namespace sven.models.data
{
    public class Set
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public double Weight { get; set; }
        public int Reps { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}