namespace InstitutoIENService.Core.Entities;

public partial class Operacione
{
    public int Id { get; set; }

    public string DeOperaciones { get; set; } = null!;

    public int IdModulo { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Modulo IdModuloNavigation { get; set; } = null!;

    public virtual ICollection<OperacionesRole> OperacionesRoles { get; set; } = new List<OperacionesRole>();
}
