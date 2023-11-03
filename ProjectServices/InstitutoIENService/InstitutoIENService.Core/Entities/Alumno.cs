namespace InstitutoIENService.Core.Entities;

public partial class Alumno
{
    public int Id { get; set; }

    public string NuLegajo { get; set; } = null!;

    public decimal? NuPromedio { get; set; }

    public DateTime? FeIngreso { get; set; }

    public DateTime? FeEgreso { get; set; }

    public decimal? NuPromedioGral { get; set; }

    public int IdPlanEstudio { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual Rrhh IdNavigation { get; set; } = null!;

    public virtual PlanesEstudio IdPlanEstudioNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
