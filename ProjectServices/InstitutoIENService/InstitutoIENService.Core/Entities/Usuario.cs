namespace InstitutoIENService.Core.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string DeNombreCuenta { get; set; } = null!;

    public string DeContrasenia { get; set; } = null!;

    public int IdRrhh { get; set; }

    public int IdRol { get; set; }

    public string SnActivo { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Role IdRolNavigation { get; set; } = null!;

    public virtual Rrhh IdRrhhNavigation { get; set; } = null!;

    public virtual ICollection<Notificacione> Notificaciones { get; set; } = new List<Notificacione>();
}
