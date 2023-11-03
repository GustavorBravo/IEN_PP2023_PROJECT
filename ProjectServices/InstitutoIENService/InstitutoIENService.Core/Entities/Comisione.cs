namespace InstitutoIENService.Core.Entities;

public partial class Comisione
{
    public int Id { get; set; }

    public string DeDescripcion { get; set; } = null!;

    public string NuCodigoComision { get; set; } = null!;

    public int NuAnioComision { get; set; }

    public string DeCarrera { get; set; } = null!;

    public string DeAnioDeMateria { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ComisionesDetalle> ComisionesDetalles { get; set; } = new List<ComisionesDetalle>();
}
