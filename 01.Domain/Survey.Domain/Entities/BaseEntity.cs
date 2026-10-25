

namespace Survey.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime DeletedAt { get; private set; }


        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
