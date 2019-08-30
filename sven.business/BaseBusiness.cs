using sven.models;
using sven.models.access;

namespace sven.business
{
    public class BaseBusiness
    {
        public SvenDbContext Context { set; get; }
        public BaseModel Model { get; set; }
    }
}