using Infrastructure.Interface;

namespace Infrastructure
{
    public class LockableEntity : BaseEntity, ILockableEntity
    {
        public bool IsLocked { get; set; }
        public string LockedByUserId { get; set; }
        public string LockedByUserEmail { get; set; }
        public DateTime? LockedDate { get; set; }

        public void StartEdit(string userId, string userEmail)
        {
            IsLocked = true;
            LockedByUserId = userId;
            LockedByUserEmail = userEmail;
            LockedDate = DateTime.UtcNow;
        }

        public void EndEdit()
        {
            // Hebe die Sperre auf
            IsLocked = false;
            LockedByUserId = null;
            LockedByUserEmail = null;
            LockedDate = null;
        }
    }
}