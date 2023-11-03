namespace InstitutoIENService.Core.Entities;

public partial class ProfesoresMateria
{
    public int IdProfesor { get; set; }

    public int IdMateria { get; set; }

    public string? TiCargo { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual Profesore IdProfesorNavigation { get; set; } = null!;
}
