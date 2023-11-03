namespace InstitutoIENService.Core.Entities;

public partial class Administrativo
{
    public int Id { get; set; }

    public DateTime? FeIngreso { get; set; }

    public DateTime? FeBaja { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Rrhh IdNavigation { get; set; } = null!;
}
