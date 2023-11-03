namespace InstitutoIENService.Core.Entities;

public partial class Paise
{
    public int Id { get; set; }

    public string DePais { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();
}
