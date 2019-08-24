using System;
using sven.models.enums;

namespace sven.models.data
{
    public class Workout
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public EExercise Exercise { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}