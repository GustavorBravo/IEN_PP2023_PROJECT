namespace InstitutoIENService.Core.Entities;

public partial class Rrhh
{
    public int Id { get; set; }

    public int NuDni { get; set; }

    public string DeNombre { get; set; } = null!;

    public string DeApellido { get; set; } = null!;

    public int NuCelular1 { get; set; }

    public int NuCelular2 { get; set; }

    public int NuCelular3 { get; set; }

    public int NuTelefono1 { get; set; }

    public int NuTelefono2 { get; set; }

    public int NuTelefono3 { get; set; }

    public string DeDireccion { get; set; } = null!;

    public string DeGenero { get; set; } = null!;

    public int IdEstadoCivil { get; set; }

    public int IdCategoriaRrhh { get; set; }

    public string? DeMail { get; set; }

    public DateTime FeNacimiento { get; set; }

    public int IdLocalidad { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Administrativo? Administrativo { get; set; }

    public virtual Alumno? Alumno { get; set; }

    public virtual CategoriasRrhh IdCategoriaRrhhNavigation { get; set; } = null!;

    public virtual EstadosCivile IdEstadoCivilNavigation { get; set; } = null!;

    public virtual Localidade IdLocalidadNavigation { get; set; } = null!;

    public virtual Profesore? Profesore { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
