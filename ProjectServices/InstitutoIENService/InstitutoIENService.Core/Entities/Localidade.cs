using System;
using System.Collections.Generic;

namespace InstitutoIENService.Core.Entities;

public partial class Localidade
{
    public int Id { get; set; }

    public string DeLocalidad { get; set; } = null!;

    public int IdProvincia { get; set; }

    public DateTime FeRegistro { get; set; }

    public DateTime? FeModificacion { get; set; }

    public virtual Provincia IdProvinciaNavigation { get; set; } = null!;

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
