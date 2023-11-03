namespace InstitutoIENService.Core.Entities;

public partial class Carrera
{
    public int Id { get; set; }

    public string DeCarrera { get; set; } = null!;

    public string DeSede { get; set; } = null!;

    public int NuDuracionHoras { get; set; }

    public string DeResponsable { get; set; } = null!;

    public int IdPlanEstudio { get; set; }

    public string? TiCarrera { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual PlanesEstudio IdPlanEstudioNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
