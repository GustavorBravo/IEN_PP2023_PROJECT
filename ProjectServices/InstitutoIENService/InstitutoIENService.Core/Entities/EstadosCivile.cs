namespace InstitutoIENService.Core.Entities;

public partial class EstadosCivile
{
    public int Id { get; set; }

    public string DeEstadoCivil { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
