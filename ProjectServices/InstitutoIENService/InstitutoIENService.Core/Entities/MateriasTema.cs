namespace InstitutoIENService.Core.Entities;

public partial class MateriasTema
{
    public int IdMateria { get; set; }

    public int IdTema { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual Tema IdTemaNavigation { get; set; } = null!;
}
