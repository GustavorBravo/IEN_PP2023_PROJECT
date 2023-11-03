namespace InstitutoIENService.Core.Entities;

public partial class Modulo
{
    public int Id { get; set; }

    public string DeModulo { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Operacione> Operaciones { get; set; } = new List<Operacione>();
}
