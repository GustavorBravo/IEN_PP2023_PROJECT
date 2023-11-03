namespace InstitutoIENService.Core.Entities;

public partial class Aula
{
    public int Id { get; set; }

    public int NuCapacidadMax { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();
}
