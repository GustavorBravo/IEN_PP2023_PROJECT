namespace InstitutoIENService.Core.Entities;

public partial class OperacionesRole
{
    public int IdOperacion { get; set; }

    public int IdRol { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Operacione IdOperacionNavigation { get; set; } = null!;

    public virtual Role IdRolNavigation { get; set; } = null!;
}
