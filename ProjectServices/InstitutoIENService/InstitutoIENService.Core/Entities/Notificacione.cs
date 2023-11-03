namespace InstitutoIENService.Core.Entities;

public partial class Notificacione
{
    public int Id { get; set; }

    public string DeMensaje { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
