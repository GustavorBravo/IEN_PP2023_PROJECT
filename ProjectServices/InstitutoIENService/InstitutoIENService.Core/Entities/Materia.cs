namespace InstitutoIENService.Core.Entities;

public partial class Materia
{
    public int Id { get; set; }

    public string DeNombre { get; set; } = null!;

    public int IdCarrera { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual ICollection<MateriasTema> MateriasTemas { get; set; } = new List<MateriasTema>();

    public virtual ICollection<ProfesoresMateria> ProfesoresMateria { get; set; } = new List<ProfesoresMateria>();
}
