namespace InstitutoIENService.Core.Entities;

public partial class ProfesoresTitulo
{
    public int IdProfesor { get; set; }

    public int IdTitulo { get; set; }

    public string? ReImagenTitulo { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Profesore IdProfesorNavigation { get; set; } = null!;

    public virtual Titulo IdTituloNavigation { get; set; } = null!;
}
