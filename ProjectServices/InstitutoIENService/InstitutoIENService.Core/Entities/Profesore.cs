namespace InstitutoIENService.Core.Entities;

public partial class Profesore
{
    public int Id { get; set; }

    public string? NuMatricula { get; set; }

    public DateTime? FeIngreso { get; set; }

    public DateTime? FeBaja { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual Rrhh IdNavigation { get; set; } = null!;

    public virtual ICollection<ProfesoresMateria> ProfesoresMateria { get; set; } = new List<ProfesoresMateria>();

    public virtual ICollection<ProfesoresTitulo> ProfesoresTitulos { get; set; } = new List<ProfesoresTitulo>();
}
