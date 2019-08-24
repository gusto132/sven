using System;
using sven.models.enums;

namespace sven.models.data
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EMetric Metric { get; set; }
        public EGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}