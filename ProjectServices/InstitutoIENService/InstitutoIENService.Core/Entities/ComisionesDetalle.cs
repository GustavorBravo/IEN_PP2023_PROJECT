namespace InstitutoIENService.Core.Entities;

public partial class ComisionesDetalle
{
    public int Id { get; set; }

    public int IdComision { get; set; }

    public int IdAlumno { get; set; }

    public int IdMateria { get; set; }

    public int IdAula { get; set; }

    public int IdHorario { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Aula IdAulaNavigation { get; set; } = null!;

    public virtual Comisione IdComisionNavigation { get; set; } = null!;

    public virtual Horario IdHorarioNavigation { get; set; } = null!;

    public virtual Materia IdMateriaNavigation { get; set; } = null!;
}
