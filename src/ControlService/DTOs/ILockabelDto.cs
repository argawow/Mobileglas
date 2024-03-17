
namespace ControlService.DTOs
{
    public class LockabelDto
    {
        public bool IsLocked { get; set; }
        public string LockedByUserId { get; set; }
        public string LockedByUserEmail { get; set; }
    }
}