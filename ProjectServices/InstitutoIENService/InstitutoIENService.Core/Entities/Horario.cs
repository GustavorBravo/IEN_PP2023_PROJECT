namespace InstitutoIENService.Core.Entities;

public partial class Horario
{
    public int Id { get; set; }

    public TimeSpan HrInicio { get; set; }

    public TimeSpan HrFin { get; set; }

    public int NuDia { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();
}
