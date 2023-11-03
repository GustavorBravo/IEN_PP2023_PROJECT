namespace InstitutoIENService.Core.Entities;

public partial class Inscripcione
{
    public int IdAlumno { get; set; }

    public int IdCarrera { get; set; }

    public DateTime FeInscripcion { get; set; }

    public int IdPlanEstudio { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual PlanesEstudio IdPlanEstudioNavigation { get; set; } = null!;
}
