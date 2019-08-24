using System.Collections.Generic;
using sven.models.enums;

namespace sven.models.view
{
    public class WorkoutView
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public EExercise Exercise { get; set; }
        public List<SetView> Sets { get; set; }
    }
}