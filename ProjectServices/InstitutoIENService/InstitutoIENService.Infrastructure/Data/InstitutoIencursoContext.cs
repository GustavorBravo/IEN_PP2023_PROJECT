using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENService.Infrastructure.Data;

public partial class InstitutoIencursoContext : DbContext
{
    public InstitutoIencursoContext()
    {
    }

    public InstitutoIencursoContext(DbContextOptions<InstitutoIencursoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrativo> Administrativos { get; set; }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<CategoriasRrhh> CategoriasRrhhs { get; set; }

    public virtual DbSet<Comisione> Comisiones { get; set; }

    public virtual DbSet<ComisionesDetalle> ComisionesDetalles { get; set; }

    public virtual DbSet<EstadosCivile> EstadosCiviles { get; set; }

    public virtual DbSet<Examene> Examenes { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<MateriasTema> MateriasTemas { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<Notificacione> Notificaciones { get; set; }

    public virtual DbSet<Operacione> Operaciones { get; set; }

    public virtual DbSet<OperacionesRole> OperacionesRoles { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<PlanesEstudio> PlanesEstudios { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    public virtual DbSet<ProfesoresMateria> ProfesoresMaterias { get; set; }

    public virtual DbSet<ProfesoresTitulo> ProfesoresTitulos { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Rrhh> Rrhhs { get; set; }

    public virtual DbSet<Tema> Temas { get; set; }

    public virtual DbSet<Titulo> Titulos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrativo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_administrativo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FeBaja)
                .HasColumnType("datetime")
                .HasColumnName("fe_baja");
            entity.Property(e => e.FeIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fe_ingreso");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Administrativo)
                .HasForeignKey<Administrativo>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ad_rrhh");
        });

        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_alumno");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FeEgreso)
                .HasColumnType("datetime")
                .HasColumnName("fe_egreso");
            entity.Property(e => e.FeIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fe_ingreso");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("id_plan_estudio");
            entity.Property(e => e.NuLegajo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nu_legajo");
            entity.Property(e => e.NuPromedio)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("nu_promedio");
            entity.Property(e => e.NuPromedioGral)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("nu_promedio_gral");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Alumno)
                .HasForeignKey<Alumno>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_al_rrhh");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdPlanEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_al_plan_estudio");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_aula");

            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.NuCapacidadMax).HasColumnName("nu_capacidad_max");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_carrera");

            entity.Property(e => e.DeCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_carrera");
            entity.Property(e => e.DeResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_responsable");
            entity.Property(e => e.DeSede)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_sede");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("id_plan_estudio");
            entity.Property(e => e.NuDuracionHoras).HasColumnName("nu_duracion_horas");
            entity.Property(e => e.TiCarrera)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ti_carrera");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Carreras)
                .HasForeignKey(d => d.IdPlanEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ca_plan_estudio");
        });

        modelBuilder.Entity<CategoriasRrhh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_categoria_rrhh");

            entity.ToTable("Categorias_Rrhh");

            entity.Property(e => e.DeCategoriaRrhh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_categoria_rrhh");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Comisione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_comision");

            entity.Property(e => e.DeAnioDeMateria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("de_anio_de_materia");
            entity.Property(e => e.DeCarrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_carrera");
            entity.Property(e => e.DeDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_descripcion");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.NuAnioComision).HasColumnName("nu_anio_comision");
            entity.Property(e => e.NuCodigoComision)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("nu_codigo_comision");
        });

        modelBuilder.Entity<ComisionesDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_comision_detalle");

            entity.ToTable("Comisiones_Detalles");

            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdAula).HasColumnName("id_aula");
            entity.Property(e => e.IdComision).HasColumnName("id_comision");
            entity.Property(e => e.IdHorario).HasColumnName("id_horario");
            entity.Property(e => e.IdMateria).HasColumnName("id_materia");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.ComisionesDetalles)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_alumno");

            entity.HasOne(d => d.IdAulaNavigation).WithMany(p => p.ComisionesDetalles)
                .HasForeignKey(d => d.IdAula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_aula");

            entity.HasOne(d => d.IdComisionNavigation).WithMany(p => p.ComisionesDetalles)
                .HasForeignKey(d => d.IdComision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_comision");

            entity.HasOne(d => d.IdHorarioNavigation).WithMany(p => p.ComisionesDetalles)
                .HasForeignKey(d => d.IdHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_horario");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.ComisionesDetalles)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_materia");
        });

        modelBuilder.Entity<EstadosCivile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_estadocivil");

            entity.ToTable("Estados_Civiles");

            entity.Property(e => e.DeEstadoCivil)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_estado_civil");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Examene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_examen");

            entity.Property(e => e.DeCondicion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_condicion");
            entity.Property(e => e.FeExamen)
                .HasColumnType("date")
                .HasColumnName("fe_examen");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.HrExamen).HasColumnName("hr_examen");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.NuNota)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("nu_nota");
            entity.Property(e => e.SnAusente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sn_ausente");
            entity.Property(e => e.TiExamen)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ti_examen");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_alumno");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_materia");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_profesor");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_horario");

            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.HrFin).HasColumnName("hr_fin");
            entity.Property(e => e.HrInicio).HasColumnName("hr_inicio");
            entity.Property(e => e.NuDia).HasColumnName("nu_dia");
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.HasKey(e => new { e.IdAlumno, e.IdCarrera }).HasName("pk_alumno_carrera");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");
            entity.Property(e => e.FeInscripcion)
                .HasColumnType("datetime")
                .HasColumnName("fe_inscripcion");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdPlanEstudio).HasColumnName("id_plan_estudio");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_alumno");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_carrera");

            entity.HasOne(d => d.IdPlanEstudioNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdPlanEstudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_plan_estudio");
        });

        modelBuilder.Entity<Localidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_localidad");

            entity.Property(e => e.DeLocalidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_localidad");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Localidades)
                .HasForeignKey(d => d.IdProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lo_provincias");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_materia");

            entity.Property(e => e.DeNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_nombre");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdCarrera).HasColumnName("id_carrera");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ma_carrera");
        });

        modelBuilder.Entity<MateriasTema>(entity =>
        {
            entity.HasKey(e => new { e.IdMateria, e.IdTema }).HasName("pk_materia_tema");

            entity.ToTable("Materias_Temas");

            entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            entity.Property(e => e.IdTema).HasColumnName("id_tema");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.MateriasTemas)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mt_materia");

            entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.MateriasTemas)
                .HasForeignKey(d => d.IdTema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mt_tema");
        });

        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_modulo");

            entity.Property(e => e.DeModulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_modulo");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Notificacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_notificacion");

            entity.Property(e => e.DeMensaje)
                .HasColumnType("text")
                .HasColumnName("de_mensaje");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Notificaciones)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_no_usuario");
        });

        modelBuilder.Entity<Operacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_operacion");

            entity.Property(e => e.DeOperaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_operaciones");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdModulo).HasColumnName("id_modulo");

            entity.HasOne(d => d.IdModuloNavigation).WithMany(p => p.Operaciones)
                .HasForeignKey(d => d.IdModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_op_modulo");
        });

        modelBuilder.Entity<OperacionesRole>(entity =>
        {
            entity.HasKey(e => new { e.IdOperacion, e.IdRol }).HasName("pk_operacionrol");

            entity.ToTable("Operaciones_Roles");

            entity.Property(e => e.IdOperacion).HasColumnName("id_operacion");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");

            entity.HasOne(d => d.IdOperacionNavigation).WithMany(p => p.OperacionesRoles)
                .HasForeignKey(d => d.IdOperacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_or_operacion");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.OperacionesRoles)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_or_rol");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pais");

            entity.Property(e => e.DePais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_pais");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<PlanesEstudio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_plan_estudio");

            entity.ToTable("Planes_Estudios");

            entity.Property(e => e.DeObservacion)
                .HasColumnType("text")
                .HasColumnName("de_observacion");
            entity.Property(e => e.DePlan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_plan");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.NuAnioPlan).HasColumnName("nu_anio_plan");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_profesor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FeBaja)
                .HasColumnType("datetime")
                .HasColumnName("fe_baja");
            entity.Property(e => e.FeIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fe_ingreso");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.NuMatricula)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nu_matricula");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Profesore)
                .HasForeignKey<Profesore>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pr_rrhh");
        });

        modelBuilder.Entity<ProfesoresMateria>(entity =>
        {
            entity.HasKey(e => new { e.IdProfesor, e.IdMateria }).HasName("pk_profesormateria");

            entity.ToTable("Profesores_Materias");

            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.TiCargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ti_cargo");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.ProfesoresMateria)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pm_materia");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.ProfesoresMateria)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pm_profesor");
        });

        modelBuilder.Entity<ProfesoresTitulo>(entity =>
        {
            entity.HasKey(e => new { e.IdProfesor, e.IdTitulo }).HasName("pk_profesortitulo");

            entity.ToTable("Profesores_Titulos");

            entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.ReImagenTitulo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("re_imagen_titulo");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.ProfesoresTitulos)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pt_profesor");

            entity.HasOne(d => d.IdTituloNavigation).WithMany(p => p.ProfesoresTitulos)
                .HasForeignKey(d => d.IdTitulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pt_titulo");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_provincia");

            entity.Property(e => e.DeProvincia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_provincia");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pv_pais");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_rol");

            entity.Property(e => e.DeRol)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_rol");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Rrhh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_rrhh");

            entity.ToTable("RRHH");

            entity.Property(e => e.DeApellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_apellido");
            entity.Property(e => e.DeDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_direccion");
            entity.Property(e => e.DeGenero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("de_genero");
            entity.Property(e => e.DeMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_mail");
            entity.Property(e => e.DeNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_nombre");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fe_nacimiento");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdCategoriaRrhh).HasColumnName("id_categoria_rrhh");
            entity.Property(e => e.IdEstadoCivil).HasColumnName("id_estado_civil");
            entity.Property(e => e.IdLocalidad).HasColumnName("id_localidad");
            entity.Property(e => e.NuCelular1).HasColumnName("nu_celular1");
            entity.Property(e => e.NuCelular2).HasColumnName("nu_celular2");
            entity.Property(e => e.NuCelular3).HasColumnName("nu_celular3");
            entity.Property(e => e.NuDni).HasColumnName("nu_dni");
            entity.Property(e => e.NuTelefono1).HasColumnName("nu_telefono1");
            entity.Property(e => e.NuTelefono2).HasColumnName("nu_telefono2");
            entity.Property(e => e.NuTelefono3).HasColumnName("nu_telefono3");

            entity.HasOne(d => d.IdCategoriaRrhhNavigation).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.IdCategoriaRrhh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rh_categoria");

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.IdEstadoCivil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rh_estado_civil");

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.IdLocalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localidad");
        });

        modelBuilder.Entity<Tema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tema");

            entity.Property(e => e.DeDescripcion)
                .HasColumnType("text")
                .HasColumnName("de_descripcion");
            entity.Property(e => e.DeTitulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_titulo");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Titulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_titulo");

            entity.Property(e => e.DeTitulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_titulo");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_usuario");

            entity.Property(e => e.DeContrasenia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("de_contrasenia");
            entity.Property(e => e.DeNombreCuenta)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("de_nombre_cuenta");
            entity.Property(e => e.FeModificacion)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            entity.Property(e => e.FeRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdRrhh).HasColumnName("id_rrhh");
            entity.Property(e => e.SnActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('S')")
                .HasColumnName("sn_activo");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_us_rol");

            entity.HasOne(d => d.IdRrhhNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRrhh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_us_rrhh");
        });


    }


}
