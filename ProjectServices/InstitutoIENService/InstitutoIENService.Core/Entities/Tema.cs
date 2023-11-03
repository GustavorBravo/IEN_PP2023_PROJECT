namespace InstitutoIENService.Core.Entities;
public partial class Tema
{
    public int Id { get; set; }

    public string DeTitulo { get; set; } = null!;

    public string DeDescripcion { get; set; } = null!;

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<MateriasTema> MateriasTemas { get; set; } = new List<MateriasTema>();
}
