using System.ComponentModel.DataAnnotations;
using Infrastructure.Interface;
using MongoDB.Entities;

public class Control : Entity, ILockableEntity
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public List<Item> Items { get; set; }

    public int Dependence { get; set; }

    [Required]
    [StringLength(50)]
    public string Target { get; set; }

    public DateTime? IsDeleted { get; set; }

    [Required]
    [StringLength(100)]
    public string AddBy { get; set; }
    public DateTime AddDate { get; set; } = DateTime.UtcNow;

    public string EditBy { get; set; }
    public DateTime? EditDate { get; set; }

    [StringLength(450)]
    public string Bemerkung { get; set; }


    //ILockableEntity
    public bool IsLocked { get; set; }
    public string LockedByUserId { get; set; }
    public string LockedByUserEmail { get; set; }
    public DateTime? LockedDate { get; set; }

    public void EndEdit()
    {
        throw new NotImplementedException();
    }

    public void StartEdit(string userId, string userEmail)
    {
        throw new NotImplementedException();
    }
}

public class Item : Entity
{
    public List<Tenant> Tenants { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public bool Aktiv { get; set; }

    public int Index { get; set; }

    public int RowIndex { get; set; }


    [StringLength(450)]
    public string Bemerkung { get; set; }


    [StringLength(255)]
    public string ImageName { get; set; }

    public List<Sprache> Sprachen { get; set; }
    public List<Parameter> Parameter { get; set; }

    [Required]
    [StringLength(100)]
    public string AddBy { get; set; }
    public DateTime AddDate { get; set; } = DateTime.UtcNow;

    public string EditBy { get; set; }
    public DateTime? EditDate { get; set; }

    //ILockableEntity
    public bool IsLocked { get; set; }
    public string LockedByUserId { get; set; }
    public string LockedByUserEmail { get; set; }
    public DateTime? LockedDate { get; set; }

    public void EndEdit()
    {
        throw new NotImplementedException();
    }

    public void StartEdit(string userId, string userEmail)
    {
        throw new NotImplementedException();
    }
}

public class Sprache
{
    [Required]
    [StringLength(2)]
    public string ShortCode { get; set; }

    [Required]
    [StringLength(5)]
    public string FullCode { get; set; }

    [Required]
    [StringLength(255)]
    public string Value1 { get; set; }

    [StringLength(450)]
    public string Beschreibung { get; set; }
}

public class Parameter
{
    public DateTime? IsDeleted { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [StringLength(255)]
    public string Value { get; set; }

    [StringLength(450)]
    public string Bemerkung { get; set; }

    [Required]
    [StringLength(100)]
    public string AddBy { get; set; }
    public DateTime AddDate { get; set; } = DateTime.UtcNow;
}

public class Tenant : Entity
{
    [Required]
    public string TenantId { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    // Weitere Eigenschaften je nach Bedarf
}