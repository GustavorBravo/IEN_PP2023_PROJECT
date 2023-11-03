namespace InstitutoIENService.Core.Entities;

public partial class PlanesEstudio
{
    public int Id { get; set; }

    public string DePlan { get; set; } = null!;

    public string? DeObservacion { get; set; }

    public int NuAnioPlan { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Carrera> Carreras { get; set; } = new List<Carrera>();

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
