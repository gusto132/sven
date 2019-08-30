using System;

namespace sven.models.data
{
    public class User : BaseModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}