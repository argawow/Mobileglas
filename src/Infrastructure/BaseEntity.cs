using Infrastructure.Interface;

namespace Infrastructure
{

    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? IsDeleted { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }
    }
}