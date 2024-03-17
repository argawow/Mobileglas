namespace Infrastructure.Interface
{
    public interface ILockableEntity
    {
        bool IsLocked { get; set; }
        string LockedByUserId { get; set; }
        string LockedByUserEmail { get; set;}
        DateTime? LockedDate { get; set; }

        void StartEdit(string userId, string userEmail);
        void EndEdit();
    }
}