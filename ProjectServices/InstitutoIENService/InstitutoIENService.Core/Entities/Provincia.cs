namespace InstitutoIENService.Core.Entities;

public partial class Provincia
{
    public int Id { get; set; }

    public string DeProvincia { get; set; } = null!;

    public int IdPais { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Paise IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<Localidade> Localidades { get; set; } = new List<Localidade>();
}
