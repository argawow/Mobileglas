
namespace ControlService.DTOs
{
    public class ControlDto : LockabelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Target { get; set; }
        public int Dependence { get; set; }
        public DateTime? IsDeleted { get; set; }
        public string AddBy { get; set; }
        public DateTime AddDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }
    }
}