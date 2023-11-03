namespace InstitutoIENService.Core.Entities;

public partial class CategoriasRrhh
{
    public int Id { get; set; }

    public string DeCategoriaRrhh { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
