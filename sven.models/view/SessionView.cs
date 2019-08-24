using System;
using System.Collections.Generic;
using sven.models.enums;

namespace sven.models.view
{
    class SessionView
    {
        public int Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public EStatus Status { get; set; }
        public List<WorkoutView> Workouts { get; set; }
    }
}