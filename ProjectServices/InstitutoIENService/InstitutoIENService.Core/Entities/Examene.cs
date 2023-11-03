namespace InstitutoIENService.Core.Entities;

public partial class Examene
{
    public int Id { get; set; }

    public decimal NuNota { get; set; }

    public string DeCondicion { get; set; } = null!;

    public int IdAlumno { get; set; }

    public int IdMateria { get; set; }

    public int IdProfesor { get; set; }

    public string TiExamen { get; set; } = null!;

    public DateTime FeExamen { get; set; }

    public TimeSpan HrExamen { get; set; }

    public string SnAusente { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual Profesore IdProfesorNavigation { get; set; } = null!;
}
