namespace Infrastructure.Interface
{
public interface IBaseEntity
    {
        DateTime? IsDeleted { get; set; }
        string AddBy { get; set; }
        DateTime AddDate { get; set; }
        string EditBy { get; set; }
        DateTime? EditDate { get; set; }
    }
}