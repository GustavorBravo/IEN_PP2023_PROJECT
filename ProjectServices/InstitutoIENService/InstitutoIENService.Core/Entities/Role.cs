namespace InstitutoIENService.Core.Entities;

public partial class Role
{
    public int Id { get; set; }

    public string DeRol { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<OperacionesRole> OperacionesRoles { get; set; } = new List<OperacionesRole>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
