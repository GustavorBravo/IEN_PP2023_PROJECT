namespace InstitutoIENService.Core.Entities;

public partial class Titulo
{
    public int Id { get; set; }

    public string? DeTitulo { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual ICollection<ProfesoresTitulo> ProfesoresTitulos { get; set; } = new List<ProfesoresTitulo>();
}
