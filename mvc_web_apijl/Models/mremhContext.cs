using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mvc_web_apijl.Models
{
    public partial class mremhContext : DbContext
    {
        public mremhContext()
        {
        }

        /*public mremhContext(DbContextOptions<mremhContext> options)
            : base(options)
        {
        }*/

        public virtual DbSet<Acceso> Acceso { get; set; }
        public virtual DbSet<Ant> Ant { get; set; }
        public virtual DbSet<Ant1> Ant1 { get; set; }
        public virtual DbSet<Catalogo> Catalogo { get; set; }
        public virtual DbSet<CatalogoDetalle> CatalogoDetalle { get; set; }
        public virtual DbSet<Circuito> Circuito { get; set; }
        public virtual DbSet<CiudadCanton> CiudadCanton { get; set; }
        public virtual DbSet<Cne> Cne { get; set; }
        public virtual DbSet<Cne1> Cne1 { get; set; }
        public virtual DbSet<Continente> Continente { get; set; }
        public virtual DbSet<DatosPrincipales> DatosPrincipales { get; set; }
        public virtual DbSet<DatosPrincipales1> DatosPrincipales1 { get; set; }
        public virtual DbSet<Detalleusuario> Detalleusuario { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<EstadoProvincia> EstadoProvincia { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<FuncionalidadGruporol> FuncionalidadGruporol { get; set; }
        public virtual DbSet<FuncionalidadRol> FuncionalidadRol { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Gruporol> Gruporol { get; set; }
        public virtual DbSet<Jnda> Jnda { get; set; }
        public virtual DbSet<Jnda1> Jnda1 { get; set; }
        public virtual DbSet<LineamientoPnbv> LineamientoPnbv { get; set; }
        public virtual DbSet<MacrosectorSenplades> MacrosectorSenplades { get; set; }
        public virtual DbSet<MetaPnbv> MetaPnbv { get; set; }
        public virtual DbSet<MinisterioEducacion> MinisterioEducacion { get; set; }
        public virtual DbSet<MinisterioEducacion1> MinisterioEducacion1 { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<ObjetivoPnbv> ObjetivoPnbv { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parroquia> Parroquia { get; set; }
        public virtual DbSet<PeriodoPnbv> PeriodoPnbv { get; set; }
        public virtual DbSet<PocPersonalData> PocPersonalData { get; set; }
        public virtual DbSet<PoliticaPnbv> PoliticaPnbv { get; set; }
        public virtual DbSet<Programa> Programa { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<ProyectoBeneficiario> ProyectoBeneficiario { get; set; }
        public virtual DbSet<ProyectoContraparte> ProyectoContraparte { get; set; }
        public virtual DbSet<ProyectoCooperante> ProyectoCooperante { get; set; }
        public virtual DbSet<ProyectoDesembolso> ProyectoDesembolso { get; set; }
        public virtual DbSet<ProyectoEntidad> ProyectoEntidad { get; set; }
        public virtual DbSet<ProyectoModalidadCooperacion> ProyectoModalidadCooperacion { get; set; }
        public virtual DbSet<ProyectoObservacion> ProyectoObservacion { get; set; }
        public virtual DbSet<ProyectoOtraAportacion> ProyectoOtraAportacion { get; set; }
        public virtual DbSet<ProyectoPdot> ProyectoPdot { get; set; }
        public virtual DbSet<ProyectoPnbv> ProyectoPnbv { get; set; }
        public virtual DbSet<ProyectoSubsectorSenplades> ProyectoSubsectorSenplades { get; set; }
        public virtual DbSet<ProyectoUbicacion> ProyectoUbicacion { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegistroCivil> RegistroCivil { get; set; }
        public virtual DbSet<RegistroCivil1> RegistroCivil1 { get; set; }
        public virtual DbSet<RegistroPropiedad> RegistroPropiedad { get; set; }
        public virtual DbSet<RegistroPropiedad1> RegistroPropiedad1 { get; set; }
        public virtual DbSet<RmContratos> RmContratos { get; set; }
        public virtual DbSet<RmContratos1> RmContratos1 { get; set; }
        public virtual DbSet<RmSocietarios> RmSocietarios { get; set; }
        public virtual DbSet<RmSocietarios1> RmSocietarios1 { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SecapCursos> SecapCursos { get; set; }
        public virtual DbSet<SecapCursos1> SecapCursos1 { get; set; }
        public virtual DbSet<SectorSenplades> SectorSenplades { get; set; }
        public virtual DbSet<Senescyt> Senescyt { get; set; }
        public virtual DbSet<Senescyt1> Senescyt1 { get; set; }
        public virtual DbSet<Seps> Seps { get; set; }
        public virtual DbSet<Seps1> Seps1 { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Servicio1> Servicio1 { get; set; }
        public virtual DbSet<Sistema> Sistema { get; set; }
        public virtual DbSet<Sri> Sri { get; set; }
        public virtual DbSet<Sri1> Sri1 { get; set; }
        public virtual DbSet<SriEstablecimientos> SriEstablecimientos { get; set; }
        public virtual DbSet<SriEstablecimientos1> SriEstablecimientos1 { get; set; }
        public virtual DbSet<SriEstadosTributarios> SriEstadosTributarios { get; set; }
        public virtual DbSet<SriEstadosTributarios1> SriEstadosTributarios1 { get; set; }
        public virtual DbSet<SubsectorSenplades> SubsectorSenplades { get; set; }
        public virtual DbSet<Supercias> Supercias { get; set; }
        public virtual DbSet<Supercias1> Supercias1 { get; set; }
        public virtual DbSet<SuperciasAccionistas> SuperciasAccionistas { get; set; }
        public virtual DbSet<SuperciasAccionistas1> SuperciasAccionistas1 { get; set; }
        public virtual DbSet<SuperciasAdministradores> SuperciasAdministradores { get; set; }
        public virtual DbSet<SuperciasAdministradores1> SuperciasAdministradores1 { get; set; }
        public virtual DbSet<Unidadadministrativa> Unidadadministrativa { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioGupo> UsuarioGupo { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }
        public virtual DbSet<UsuarioSistema> UsuarioSistema { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("User ID=mremh_sgpj;Password=sgpjwww;Server=10.10.8.9;Port=5432;Database=mremh;Integrated Security=true;Pooling=true;");
            }
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasKey(e => e.IdAcceso);

                entity.ToTable("acceso", "seguridad");

                entity.HasIndex(e => e.IdAcceso)
                    .HasName("acceso_pk")
                    .IsUnique();

                entity.Property(e => e.IdAcceso)
                    .HasColumnName("id_acceso")
                    .HasDefaultValueSql("nextval('seguridad.acceso_id_acceso_seq'::regclass)");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasColumnName("cuenta")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<Ant>(entity =>
            {
                entity.HasKey(e => e.AntVehiculoId);

                entity.ToTable("ant", "interoperador");

                entity.HasIndex(e => e.AntVehiculoId)
                    .HasName("ant_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_ant_fk");

                entity.Property(e => e.AntVehiculoId)
                    .HasColumnName("ant_vehiculo_id")
                    .HasDefaultValueSql("nextval('interoperador.ant_ant_vehiculo_id_seq'::regclass)");

                entity.Property(e => e.AntVehiculoChasis)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_chasis")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoEstado)
                    .HasColumnName("ant_vehiculo_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoIsActivo).HasColumnName("ant_vehiculo_is_activo");

                entity.Property(e => e.AntVehiculoMarca)
                    .HasColumnName("ant_vehiculo_marca")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoModelo)
                    .HasColumnName("ant_vehiculo_modelo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoMotor)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_motor")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoPlaca)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_placa")
                    .HasColumnType("character varying(7)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Ant)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ant_fk_dp_ant_datos_pr");
            });

            modelBuilder.Entity<Ant1>(entity =>
            {
                entity.HasKey(e => e.AntVehiculoId);

                entity.ToTable("ant");

                entity.HasIndex(e => e.AntVehiculoId)
                    .HasName("ant_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_ant_fk");

                entity.Property(e => e.AntVehiculoId).HasColumnName("ant_vehiculo_id");

                entity.Property(e => e.AntVehiculoChasis)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_chasis")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoEstado)
                    .HasColumnName("ant_vehiculo_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoIsActivo).HasColumnName("ant_vehiculo_is_activo");

                entity.Property(e => e.AntVehiculoMarca)
                    .HasColumnName("ant_vehiculo_marca")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoModelo)
                    .HasColumnName("ant_vehiculo_modelo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoMotor)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_motor")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.AntVehiculoPlaca)
                    .IsRequired()
                    .HasColumnName("ant_vehiculo_placa")
                    .HasColumnType("character varying(7)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Ant1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ant_fk_dp_ant_datos_pr");
            });

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.IdCatalogo);

                entity.ToTable("catalogo", "comun");

                entity.Property(e => e.IdCatalogo)
                    .HasColumnName("id_catalogo")
                    .HasDefaultValueSql("nextval('comun.catalogo_id_catalogo_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<CatalogoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoDetalle);

                entity.ToTable("catalogo_detalle", "comun");

                entity.Property(e => e.IdCatalogoDetalle)
                    .HasColumnName("id_catalogo_detalle")
                    .HasDefaultValueSql("nextval('comun.catalogo_detalle_id_catalogo_detalle_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdCatalogoNavigation)
                    .WithMany(p => p.CatalogoDetalle)
                    .HasForeignKey(d => d.IdCatalogo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("catalogo_catalogo_detalle_fkey");
            });

            modelBuilder.Entity<Circuito>(entity =>
            {
                entity.HasKey(e => e.IdCircuito);

                entity.ToTable("circuito", "comun");

                entity.Property(e => e.IdCircuito)
                    .HasColumnName("id_circuito")
                    .HasDefaultValueSql("nextval('comun.circuito_id_circuito_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(8)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdDistrito).HasColumnName("id_distrito");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdDistritoNavigation)
                    .WithMany(p => p.Circuito)
                    .HasForeignKey(d => d.IdDistrito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("distrito_circuito");
            });

            modelBuilder.Entity<CiudadCanton>(entity =>
            {
                entity.HasKey(e => e.IdCanton);

                entity.ToTable("ciudad_canton", "comun");

                entity.Property(e => e.IdCanton)
                    .HasColumnName("id_canton")
                    .HasDefaultValueSql("nextval('comun.canton_id_canton_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(4)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.TmpIdMigracion).HasColumnName("tmp_id_migracion");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.CiudadCanton)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("provincia_canton");
            });

            modelBuilder.Entity<Cne>(entity =>
            {
                entity.HasKey(e => e.CneCodigoElectoral);

                entity.ToTable("cne");

                entity.HasIndex(e => e.CneCodigoElectoral)
                    .HasName("cne_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_cne_fk");

                entity.Property(e => e.CneCodigoElectoral)
                    .HasColumnName("cne_codigo_electoral")
                    .HasColumnType("character varying(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CneCanton)
                    .IsRequired()
                    .HasColumnName("cne_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneHabilitadoTramitePublico).HasColumnName("cne_habilitado_tramite_publico");

                entity.Property(e => e.CneIsActivo).HasColumnName("cne_is_activo");

                entity.Property(e => e.CneParroquia)
                    .IsRequired()
                    .HasColumnName("cne_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneProvincia)
                    .IsRequired()
                    .HasColumnName("cne_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneRecinto)
                    .HasColumnName("cne_recinto")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Cne)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cne_fk_dp_cne_datos_pr");
            });

            modelBuilder.Entity<Cne1>(entity =>
            {
                entity.HasKey(e => e.CneCodigoElectoral);

                entity.ToTable("cne", "interoperador");

                entity.HasIndex(e => e.CneCodigoElectoral)
                    .HasName("cne_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_cne_fk");

                entity.Property(e => e.CneCodigoElectoral)
                    .HasColumnName("cne_codigo_electoral")
                    .HasColumnType("character varying(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CneCanton)
                    .IsRequired()
                    .HasColumnName("cne_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneHabilitadoTramitePublico).HasColumnName("cne_habilitado_tramite_publico");

                entity.Property(e => e.CneIsActivo).HasColumnName("cne_is_activo");

                entity.Property(e => e.CneParroquia)
                    .IsRequired()
                    .HasColumnName("cne_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneProvincia)
                    .IsRequired()
                    .HasColumnName("cne_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.CneRecinto)
                    .HasColumnName("cne_recinto")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Cne1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cne_fk_dp_cne_datos_pr");
            });

            modelBuilder.Entity<Continente>(entity =>
            {
                entity.HasKey(e => e.IdContinente);

                entity.ToTable("continente", "comun");

                entity.Property(e => e.IdContinente)
                    .HasColumnName("id_continente")
                    .HasDefaultValueSql("nextval('comun.continente_id_continente_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<DatosPrincipales>(entity =>
            {
                entity.HasKey(e => e.DpId);

                entity.ToTable("datos_principales", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("datos_principales_pk")
                    .IsUnique();

                entity.HasIndex(e => e.WsCodigo)
                    .HasName("fk_ws_dp_fk");

                entity.Property(e => e.DpId)
                    .HasColumnName("dp_id")
                    .HasDefaultValueSql("nextval('interoperador.datos_principales_dp_id_seq'::regclass)");

                entity.Property(e => e.DpDocumento)
                    .IsRequired()
                    .HasColumnName("dp_documento")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.DpEmail)
                    .HasColumnName("dp_email")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpIsActivo).HasColumnName("dp_is_activo");

                entity.Property(e => e.DpNombres)
                    .HasColumnName("dp_nombres")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpRazonSocial)
                    .HasColumnName("dp_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpTipoDocumento)
                    .IsRequired()
                    .HasColumnName("dp_tipo_documento")
                    .HasColumnType("character varying(50)")
                    .ForNpgsqlHasComment("Cédula, Pasaporte, RUC, Placa");

                entity.Property(e => e.WsCodigo)
                    .HasColumnName("ws_codigo")
                    .ForNpgsqlHasComment("Código del paquete proporcionado por la DINARDAP");

                entity.HasOne(d => d.WsCodigoNavigation)
                    .WithMany(p => p.DatosPrincipales)
                    .HasForeignKey(d => d.WsCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_datos_pr_fk_ws_dp_servicio");
            });

            modelBuilder.Entity<DatosPrincipales1>(entity =>
            {
                entity.HasKey(e => e.DpId);

                entity.ToTable("datos_principales");

                entity.HasIndex(e => e.DpId)
                    .HasName("datos_principales_pk")
                    .IsUnique();

                entity.HasIndex(e => e.WsCodigo)
                    .HasName("fk_ws_dp_fk");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.DpDocumento)
                    .IsRequired()
                    .HasColumnName("dp_documento")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.DpEmail)
                    .HasColumnName("dp_email")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpIsActivo).HasColumnName("dp_is_activo");

                entity.Property(e => e.DpNombres)
                    .HasColumnName("dp_nombres")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpRazonSocial)
                    .HasColumnName("dp_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.DpTipoDocumento)
                    .IsRequired()
                    .HasColumnName("dp_tipo_documento")
                    .HasColumnType("character varying(50)")
                    .ForNpgsqlHasComment("Cédula, Pasaporte, RUC, Placa");

                entity.Property(e => e.WsCodigo)
                    .HasColumnName("ws_codigo")
                    .ForNpgsqlHasComment("Código del paquete proporcionado por la DINARDAP");

                entity.HasOne(d => d.WsCodigoNavigation)
                    .WithMany(p => p.DatosPrincipales1)
                    .HasForeignKey(d => d.WsCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_datos_pr_fk_ws_dp_servicio");
            });

            modelBuilder.Entity<Detalleusuario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleUsuario);

                entity.ToTable("detalleusuario", "seguridad");

                entity.HasIndex(e => e.IdDetalleUsuario)
                    .HasName("detalleusuario_pk")
                    .IsUnique();

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("usuario_detalleusuario_fk");

                entity.Property(e => e.IdDetalleUsuario)
                    .HasColumnName("id_detalle_usuario")
                    .HasDefaultValueSql("nextval('seguridad.detalleusuario_id_detalle_usuario_seq'::regclass)");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasColumnName("apellido2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasColumnName("documento")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasColumnName("nombre1")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Nombre2)
                    .HasColumnName("nombre2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Detalleusuario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_detalleu_usuario_d_usuario");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.HasKey(e => e.IdDistrito);

                entity.ToTable("distrito", "comun");

                entity.Property(e => e.IdDistrito)
                    .HasColumnName("id_distrito")
                    .HasDefaultValueSql("nextval('comun.distrito_id_distrito_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(5)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdZona).HasColumnName("id_zona");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Distrito)
                    .HasForeignKey(d => d.IdZona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zona_distrito_fkey");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.HasKey(e => e.IdEntidad);

                entity.ToTable("entidad", "comun");

                entity.Property(e => e.IdEntidad)
                    .HasColumnName("id_entidad")
                    .HasDefaultValueSql("nextval('comun.entidad_id_entidad_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(400)");

                entity.Property(e => e.Siglas)
                    .HasColumnName("siglas")
                    .HasColumnType("character varying(40)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pais_entidad_fkey");
            });

            modelBuilder.Entity<EstadoProvincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.ToTable("estado_provincia", "comun");

                entity.Property(e => e.IdProvincia)
                    .HasColumnName("id_provincia")
                    .HasDefaultValueSql("nextval('comun.provincia_id_provincia_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(2)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdRegion).HasColumnName("id_region");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.EstadoProvincia)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("pais_provincia_fkey");
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.HasKey(e => e.IdFuncionalidad);

                entity.ToTable("funcionalidad", "seguridad");

                entity.HasIndex(e => e.IdFuncionalidad)
                    .HasName("funcionalidad_pk")
                    .IsUnique();

                entity.HasIndex(e => e.IdPadre)
                    .HasName("funcionalidad_funcionalidad_fk");

                entity.Property(e => e.IdFuncionalidad)
                    .HasColumnName("id_funcionalidad")
                    .HasDefaultValueSql("nextval('seguridad.funcionalidad_id_funcionalidad_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPadre).HasColumnName("id_padre");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("id_tipo")
                    .ForNpgsqlHasComment("Tomado del catálogo");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPadreNavigation)
                    .WithMany(p => p.InverseIdPadreNavigation)
                    .HasForeignKey(d => d.IdPadre)
                    .HasConstraintName("fk_funciona_funcional_funciona");
            });

            modelBuilder.Entity<FuncionalidadGruporol>(entity =>
            {
                entity.HasKey(e => new { e.IdFuncionalidadGruporol, e.IdGrupoRol, e.IdFuncionalidad });

                entity.ToTable("funcionalidad_gruporol", "seguridad");

                entity.HasIndex(e => e.IdFuncionalidad)
                    .HasName("funcionalidad_gruporol2_fk");

                entity.HasIndex(e => e.IdGrupoRol)
                    .HasName("funcionalidad_gruporol_fk");

                entity.HasIndex(e => new { e.IdFuncionalidadGruporol, e.IdGrupoRol, e.IdFuncionalidad })
                    .HasName("funcionalidad_gruporol_pk")
                    .IsUnique();

                entity.Property(e => e.IdFuncionalidadGruporol)
                    .HasColumnName("id_funcionalidad_gruporol")
                    .HasDefaultValueSql("nextval('seguridad.funcionalidad_gruporol_id_funcionalidad_gruporol_seq'::regclass)");

                entity.Property(e => e.IdGrupoRol).HasColumnName("id_grupo_rol");

                entity.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdFuncionalidadNavigation)
                    .WithMany(p => p.FuncionalidadGruporol)
                    .HasForeignKey(d => d.IdFuncionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funciona_funcional_funciona");

                entity.HasOne(d => d.IdGrupoRolNavigation)
                    .WithMany(p => p.FuncionalidadGruporol)
                    .HasForeignKey(d => d.IdGrupoRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funciona_funcional_gruporol");
            });

            modelBuilder.Entity<FuncionalidadRol>(entity =>
            {
                entity.HasKey(e => new { e.IdFuncionalidadRol, e.IdFuncionalidad, e.IdRol });

                entity.ToTable("funcionalidad_rol", "seguridad");

                entity.HasIndex(e => e.IdFuncionalidad)
                    .HasName("funcionalidad_rol_fk");

                entity.HasIndex(e => e.IdRol)
                    .HasName("funcionalidad_rol2_fk");

                entity.HasIndex(e => new { e.IdFuncionalidadRol, e.IdFuncionalidad, e.IdRol })
                    .HasName("funcionalidad_rol_pk")
                    .IsUnique();

                entity.Property(e => e.IdFuncionalidadRol)
                    .HasColumnName("id_funcionalidad_rol")
                    .HasDefaultValueSql("nextval('seguridad.funcionalidad_rol_id_funcionalidad_rol_seq'::regclass)");

                entity.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdFuncionalidadNavigation)
                    .WithMany(p => p.FuncionalidadRol)
                    .HasForeignKey(d => d.IdFuncionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funciona_funcional_funciona");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.FuncionalidadRol)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_funciona_funcional_rol");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("grupo", "seguridad");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("grupo_pk")
                    .IsUnique();

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("id_grupo")
                    .HasDefaultValueSql("nextval('seguridad.grupo_id_grupo_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Gruporol>(entity =>
            {
                entity.HasKey(e => e.IdGrupoRol);

                entity.ToTable("gruporol", "seguridad");

                entity.HasIndex(e => e.IdGrupoRol)
                    .HasName("gruporol_pk")
                    .IsUnique();

                entity.Property(e => e.IdGrupoRol)
                    .HasColumnName("id_grupo_rol")
                    .HasDefaultValueSql("nextval('seguridad.gruporol_id_grupo_rol_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsAcivo).HasColumnName("is_acivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Jnda>(entity =>
            {
                entity.HasKey(e => e.JndId);

                entity.ToTable("jnda", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_jnd_fk");

                entity.HasIndex(e => e.JndId)
                    .HasName("jnda_pk")
                    .IsUnique();

                entity.Property(e => e.JndId)
                    .HasColumnName("jnd_id")
                    .HasDefaultValueSql("nextval('interoperador.jnda_jnd_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.JndCallePrincipalLocCom)
                    .HasColumnName("jnd_calle_principal_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCallePrincipalTaller)
                    .HasColumnName("jnd_calle_principal_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCantonLocCom)
                    .HasColumnName("jnd_canton_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCantonTaller)
                    .HasColumnName("jnd_canton_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndEdificioLocCom)
                    .HasColumnName("jnd_edificio_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndEdificioTaller)
                    .HasColumnName("jnd_edificio_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndInterseccionDelTaller)
                    .HasColumnName("jnd_interseccion_del_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndInterseccionLocCom)
                    .HasColumnName("jnd_interseccion_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndIsActivo).HasColumnName("jnd_is_activo");

                entity.Property(e => e.JndNombreRamaArtesanal)
                    .IsRequired()
                    .HasColumnName("jnd_nombre_rama_artesanal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndNumCalificacion)
                    .IsRequired()
                    .HasColumnName("jnd_num_calificacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndNumCasaLocCom)
                    .HasColumnName("jnd_num_casa_loc_com")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.JndNumCasaTaller)
                    .HasColumnName("jnd_num_casa_taller")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.JndParroquiaLocCom)
                    .HasColumnName("jnd_parroquia_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndParroquiaTaller)
                    .HasColumnName("jnd_parroquia_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndPisoLocCom)
                    .HasColumnName("jnd_piso_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndPisoTaller)
                    .HasColumnName("jnd_piso_taller")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Jnda)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_jnda_fk_dp_jnd_datos_pr");
            });

            modelBuilder.Entity<Jnda1>(entity =>
            {
                entity.HasKey(e => e.JndId);

                entity.ToTable("jnda");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_jnd_fk");

                entity.HasIndex(e => e.JndId)
                    .HasName("jnda_pk")
                    .IsUnique();

                entity.Property(e => e.JndId).HasColumnName("jnd_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.JndCallePrincipalLocCom)
                    .HasColumnName("jnd_calle_principal_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCallePrincipalTaller)
                    .HasColumnName("jnd_calle_principal_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCantonLocCom)
                    .HasColumnName("jnd_canton_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndCantonTaller)
                    .HasColumnName("jnd_canton_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndEdificioLocCom)
                    .HasColumnName("jnd_edificio_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndEdificioTaller)
                    .HasColumnName("jnd_edificio_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndInterseccionDelTaller)
                    .HasColumnName("jnd_interseccion_del_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndInterseccionLocCom)
                    .HasColumnName("jnd_interseccion_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndIsActivo).HasColumnName("jnd_is_activo");

                entity.Property(e => e.JndNombreRamaArtesanal)
                    .IsRequired()
                    .HasColumnName("jnd_nombre_rama_artesanal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndNumCalificacion)
                    .IsRequired()
                    .HasColumnName("jnd_num_calificacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndNumCasaLocCom)
                    .HasColumnName("jnd_num_casa_loc_com")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.JndNumCasaTaller)
                    .HasColumnName("jnd_num_casa_taller")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.JndParroquiaLocCom)
                    .HasColumnName("jnd_parroquia_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndParroquiaTaller)
                    .HasColumnName("jnd_parroquia_taller")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndPisoLocCom)
                    .HasColumnName("jnd_piso_loc_com")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.JndPisoTaller)
                    .HasColumnName("jnd_piso_taller")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Jnda1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_jnda_fk_dp_jnd_datos_pr");
            });

            modelBuilder.Entity<LineamientoPnbv>(entity =>
            {
                entity.HasKey(e => e.IdLineamientoPnbv);

                entity.ToTable("lineamiento_pnbv", "catalogos_externos");

                entity.Property(e => e.IdLineamientoPnbv)
                    .HasColumnName("id_lineamiento_pnbv")
                    .HasDefaultValueSql("nextval('catalogos_externos.lineamiento_pnbv_id_lineamiento_pnbv_seq'::regclass)");

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("abreviatura")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPoliticaPnbv).HasColumnName("id_politica_pnbv");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPoliticaPnbvNavigation)
                    .WithMany(p => p.LineamientoPnbv)
                    .HasForeignKey(d => d.IdPoliticaPnbv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("politica_pnbv_lineamiento_pnbv_fkey");
            });

            modelBuilder.Entity<MacrosectorSenplades>(entity =>
            {
                entity.HasKey(e => e.IdMacrosectorSenplades);

                entity.ToTable("macrosector_senplades", "catalogos_externos");

                entity.Property(e => e.IdMacrosectorSenplades)
                    .HasColumnName("id_macrosector_senplades")
                    .HasDefaultValueSql("nextval('catalogos_externos.macrosector_senplades_id_macrosector_senplades_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<MetaPnbv>(entity =>
            {
                entity.HasKey(e => e.IdMetaPnbv);

                entity.ToTable("meta_pnbv", "catalogos_externos");

                entity.Property(e => e.IdMetaPnbv)
                    .HasColumnName("id_meta_pnbv")
                    .HasDefaultValueSql("nextval('catalogos_externos.meta_pnbv_id_meta_pnbv_seq'::regclass)");

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("abreviatura")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdObjetivoPnbv).HasColumnName("id_objetivo_pnbv");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdObjetivoPnbvNavigation)
                    .WithMany(p => p.MetaPnbv)
                    .HasForeignKey(d => d.IdObjetivoPnbv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("objetivo_pnbv_meta_pnbv_fkey");
            });

            modelBuilder.Entity<MinisterioEducacion>(entity =>
            {
                entity.HasKey(e => e.EduId);

                entity.ToTable("ministerio_educacion", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_edu_fk");

                entity.HasIndex(e => e.EduId)
                    .HasName("ministerio_educacion_pk")
                    .IsUnique();

                entity.Property(e => e.EduId)
                    .HasColumnName("edu_id")
                    .HasDefaultValueSql("nextval('interoperador.ministerio_educacion_edu_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.EduCodigoRefrendacionTitulo).HasColumnName("edu_codigo_refrendacion_titulo");

                entity.Property(e => e.EduInstitucionEducativa)
                    .IsRequired()
                    .HasColumnName("edu_institucion_educativa")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.EduIsActivo).HasColumnName("edu_is_activo");

                entity.Property(e => e.EduNumeroRefrendacionTitulo)
                    .HasColumnName("edu_numero_refrendacion_titulo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.EduTipoTituloOtorgadoIe)
                    .IsRequired()
                    .HasColumnName("edu_tipo_titulo_otorgado_ie")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.MinisterioEducacion)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_minister_fk_dp_edu_datos_pr");
            });

            modelBuilder.Entity<MinisterioEducacion1>(entity =>
            {
                entity.HasKey(e => e.EduId);

                entity.ToTable("ministerio_educacion");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_edu_fk");

                entity.HasIndex(e => e.EduId)
                    .HasName("ministerio_educacion_pk")
                    .IsUnique();

                entity.Property(e => e.EduId).HasColumnName("edu_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.EduCodigoRefrendacionTitulo).HasColumnName("edu_codigo_refrendacion_titulo");

                entity.Property(e => e.EduInstitucionEducativa)
                    .IsRequired()
                    .HasColumnName("edu_institucion_educativa")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.EduIsActivo).HasColumnName("edu_is_activo");

                entity.Property(e => e.EduNumeroRefrendacionTitulo)
                    .HasColumnName("edu_numero_refrendacion_titulo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.EduTipoTituloOtorgadoIe)
                    .IsRequired()
                    .HasColumnName("edu_tipo_titulo_otorgado_ie")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.MinisterioEducacion1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_minister_fk_dp_edu_datos_pr");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.IdMoneda);

                entity.ToTable("moneda", "comun");

                entity.Property(e => e.IdMoneda)
                    .HasColumnName("id_moneda")
                    .HasDefaultValueSql("nextval('comun.moneda_id_moneda_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<ObjetivoPnbv>(entity =>
            {
                entity.HasKey(e => e.IdObjetivoPnbv);

                entity.ToTable("objetivo_pnbv", "catalogos_externos");

                entity.Property(e => e.IdObjetivoPnbv)
                    .HasColumnName("id_objetivo_pnbv")
                    .HasDefaultValueSql("nextval('catalogos_externos.objetivo_pnbv_id_objetivo_pnbv_seq'::regclass)");

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("abreviatura")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPeriodoPnbv).HasColumnName("id_periodo_pnbv");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPeriodoPnbvNavigation)
                    .WithMany(p => p.ObjetivoPnbv)
                    .HasForeignKey(d => d.IdPeriodoPnbv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("periodo_pnbv_objetivo_pnbv_fkey");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("pais", "comun");

                entity.Property(e => e.IdPais)
                    .HasColumnName("id_pais")
                    .HasDefaultValueSql("nextval('comun.pais_id_pais_seq'::regclass)");

                entity.Property(e => e.Bandera)
                    .HasColumnName("bandera")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCodigoInternacional).HasColumnName("id_codigo_internacional");

                entity.Property(e => e.IdContinente).HasColumnName("id_continente");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasColumnName("nombre_corto")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.NombreOficial)
                    .HasColumnName("nombre_oficial")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.TmpIdMigracion).HasColumnName("tmp_id_migracion");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdContinenteNavigation)
                    .WithMany(p => p.Pais)
                    .HasForeignKey(d => d.IdContinente)
                    .HasConstraintName("continente_pais_fkey");
            });

            modelBuilder.Entity<Parroquia>(entity =>
            {
                entity.HasKey(e => e.IdParroquia);

                entity.ToTable("parroquia", "comun");

                entity.Property(e => e.IdParroquia)
                    .HasColumnName("id_parroquia")
                    .HasDefaultValueSql("nextval('comun.parroquia_id_parroquia_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(6)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCanton).HasColumnName("id_canton");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.Parroquia)
                    .HasForeignKey(d => d.IdCanton)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("canton_parroquia_fkey");
            });

            modelBuilder.Entity<PeriodoPnbv>(entity =>
            {
                entity.HasKey(e => e.IdPeriodoPnbv);

                entity.ToTable("periodo_pnbv", "catalogos_externos");

                entity.Property(e => e.IdPeriodoPnbv)
                    .HasColumnName("id_periodo_pnbv")
                    .HasDefaultValueSql("nextval('catalogos_externos.periodo_pnbv_id_periodo_pnbv_seq'::regclass)");

                entity.Property(e => e.AnioFin)
                    .IsRequired()
                    .HasColumnName("anio_fin")
                    .HasColumnType("character varying(4)");

                entity.Property(e => e.AnioInicio)
                    .IsRequired()
                    .HasColumnName("anio_inicio")
                    .HasColumnType("character varying(4)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsVigente).HasColumnName("is_vigente");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<PocPersonalData>(entity =>
            {
                entity.ToTable("poc_personal_data", "interoperador");

                entity.Property(e => e.PocPersonalDataId)
                    .HasColumnName("poc_personal_data_id")
                    .HasDefaultValueSql("nextval('interoperador.poc_datos_personales_id_seq'::regclass)");

                entity.Property(e => e.PocAge)
                    .IsRequired()
                    .HasColumnName("poc_age")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocDescription)
                    .HasColumnName("poc_description")
                    .HasColumnType("character varying(250)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocFeelings)
                    .IsRequired()
                    .HasColumnName("poc_feelings")
                    .HasColumnType("character varying(100)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocGender)
                    .HasColumnName("poc_gender")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocMaritalStatus)
                    .HasColumnName("poc_marital_status")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocNames)
                    .IsRequired()
                    .HasColumnName("poc_names")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocNationality)
                    .HasColumnName("poc_nationality")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PocProfession)
                    .HasColumnName("poc_profession")
                    .HasColumnType("character varying(50)")
                    .HasDefaultValueSql("NULL::character varying");
            });

            modelBuilder.Entity<PoliticaPnbv>(entity =>
            {
                entity.HasKey(e => e.IdPoliticaPnbv);

                entity.ToTable("politica_pnbv", "catalogos_externos");

                entity.Property(e => e.IdPoliticaPnbv)
                    .HasColumnName("id_politica_pnbv")
                    .HasDefaultValueSql("nextval('catalogos_externos.politica_pnbv_id_politica_pnbv_seq'::regclass)");

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("abreviatura")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdObjetivoPnbv).HasColumnName("id_objetivo_pnbv");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdObjetivoPnbvNavigation)
                    .WithMany(p => p.PoliticaPnbv)
                    .HasForeignKey(d => d.IdObjetivoPnbv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("objetivo_pnbv_politica_pnbv_fkey");
            });

            modelBuilder.Entity<Programa>(entity =>
            {
                entity.HasKey(e => e.IdPrograma);

                entity.ToTable("programa", "proyectos_cfnr");

                entity.Property(e => e.IdPrograma)
                    .HasColumnName("id_programa")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.programa_id_programa_seq'::regclass)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdPais)
                    .HasColumnName("id_pais")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.ToTable("proyecto", "proyectos_cfnr");

                entity.Property(e => e.IdProyecto)
                    .HasColumnName("id_proyecto")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_id_proyecto_seq'::regclass)");

                entity.Property(e => e.AvanceEjecucionFisica).HasColumnName("avance_ejecucion_fisica");

                entity.Property(e => e.AvanceEjecucionPresupuestaria).HasColumnName("avance_ejecucion_presupuestaria");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("codigo")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCertificacion)
                    .HasColumnName("fecha_certificacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCertificacion).HasColumnName("id_certificacion");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdFuenteCooperacion).HasColumnName("id_fuente_cooperacion");

                entity.Property(e => e.IdPais)
                    .IsRequired()
                    .HasColumnName("id_pais")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.IdPrograma).HasColumnName("id_programa");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.ObjetivoEspecifico).HasColumnName("objetivo_especifico");

                entity.Property(e => e.ObjetivoGeneral).HasColumnName("objetivo_general");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.OtrasInstituciones).HasColumnName("otras_instituciones");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.Proyecto)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("programa_fkey");
            });

            modelBuilder.Entity<ProyectoBeneficiario>(entity =>
            {
                entity.HasKey(e => e.IdProyectoBeneficiario);

                entity.ToTable("proyecto_beneficiario", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoBeneficiario)
                    .HasColumnName("id_proyecto_beneficiario")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_beneficiario_id_proyecto_beneficiario_seq'::regclass)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IdTipoBeneficiario).HasColumnName("id_tipo_beneficiario");

                entity.Property(e => e.IdTipoBeneficio).HasColumnName("id_tipo_beneficio");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.NumeroBeneficiarios).HasColumnName("numero_beneficiarios");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoBeneficiario)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_benficiario_fkey");
            });

            modelBuilder.Entity<ProyectoContraparte>(entity =>
            {
                entity.HasKey(e => e.IdProyectoContraparte);

                entity.ToTable("proyecto_contraparte", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoContraparte)
                    .HasColumnName("id_proyecto_contraparte")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_contraparte_id_proyecto_contraparte_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdContraparte).HasColumnName("id_contraparte");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoContraparte)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_contraparte_fkey");
            });

            modelBuilder.Entity<ProyectoCooperante>(entity =>
            {
                entity.HasKey(e => e.IdProyectoCooperante);

                entity.ToTable("proyecto_cooperante", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoCooperante)
                    .HasColumnName("id_proyecto_cooperante")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_cooperante_id_proyecto_cooperante_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCooperante).HasColumnName("id_cooperante");

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IsPrincipal).HasColumnName("is_principal");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.TipoCambio).HasColumnName("tipo_cambio");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoCooperante)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_cooperante");
            });

            modelBuilder.Entity<ProyectoDesembolso>(entity =>
            {
                entity.HasKey(e => e.IdProyectoDesembolso);

                entity.ToTable("proyecto_desembolso", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoDesembolso)
                    .HasColumnName("id_proyecto_desembolso")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_desembolso_id_proyecto_desembolso_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IdProyectoContraparte).HasColumnName("id_proyecto_contraparte");

                entity.Property(e => e.IdProyectoCooperante).HasColumnName("id_proyecto_cooperante");

                entity.Property(e => e.IdProyectoOtraAportacion).HasColumnName("id_proyecto_otra_aportacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.MontoDesembolsado).HasColumnName("monto_desembolsado");

                entity.Property(e => e.MontoPresupuestado).HasColumnName("monto_presupuestado");

                entity.Property(e => e.Periodo).HasColumnName("periodo");

                entity.Property(e => e.TipoCambio).HasColumnName("tipo_cambio");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoDesembolso)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_desembolso");
            });

            modelBuilder.Entity<ProyectoEntidad>(entity =>
            {
                entity.HasKey(e => e.IdProyectoEntidad);

                entity.ToTable("proyecto_entidad", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoEntidad)
                    .HasColumnName("id_proyecto_entidad")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_entidad_id_proyecto_entidad_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdEntidad).HasColumnName("id_entidad");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoEntidad)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_entidad");
            });

            modelBuilder.Entity<ProyectoModalidadCooperacion>(entity =>
            {
                entity.HasKey(e => e.IdProyectoModalidadCooperacion);

                entity.ToTable("proyecto_modalidad_cooperacion", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoModalidadCooperacion)
                    .HasColumnName("id_proyecto_modalidad_cooperacion")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_modalidad_cooperacio_id_proyecto_modalidad_coopera_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdModalidadCooperacion).HasColumnName("id_modalidad_cooperacion");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoModalidadCooperacion)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_modalidad_cooperacion_fkey");
            });

            modelBuilder.Entity<ProyectoObservacion>(entity =>
            {
                entity.HasKey(e => e.IdProyectoObservacion);

                entity.ToTable("proyecto_observacion", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoObservacion)
                    .HasColumnName("id_proyecto_observacion")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_observacion_id_proyecto_observacion_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdFicha).HasColumnName("id_ficha");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Observacion).HasColumnName("observacion");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoObservacion)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_observacion_fkey");
            });

            modelBuilder.Entity<ProyectoOtraAportacion>(entity =>
            {
                entity.HasKey(e => e.IdProyectoOtraAportacion);

                entity.ToTable("proyecto_otra_aportacion", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoOtraAportacion)
                    .HasColumnName("id_proyecto_otra_aportacion")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_otra_aportacion_id_proyecto_otra_aportacion_seq'::regclass)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IsCuantificable).HasColumnName("is_cuantificable");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoOtraAportacion)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_otra_aportacion_fkey");
            });

            modelBuilder.Entity<ProyectoPdot>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPdot);

                entity.ToTable("proyecto_pdot", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoPdot)
                    .HasColumnName("id_proyecto_pdot")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_pdot_id_proyecto_pdot_seq'::regclass)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IdTipoPdot).HasColumnName("id_tipo_pdot");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoPdot)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_pdot_fkey");
            });

            modelBuilder.Entity<ProyectoPnbv>(entity =>
            {
                entity.HasKey(e => e.IdProyectoPnbv);

                entity.ToTable("proyecto_pnbv", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoPnbv)
                    .HasColumnName("id_proyecto_pnbv")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_pnbv_id_proyecto_pnbv_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdLineamiento).HasColumnName("id_lineamiento");

                entity.Property(e => e.IdMeta).HasColumnName("id_meta");

                entity.Property(e => e.IdObjetivo).HasColumnName("id_objetivo");

                entity.Property(e => e.IdPolitica).HasColumnName("id_politica");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdLineamientoNavigation)
                    .WithMany(p => p.ProyectoPnbv)
                    .HasForeignKey(d => d.IdLineamiento)
                    .HasConstraintName("proyecto_pnbv_lineamiento_pnbv_fkey");

                entity.HasOne(d => d.IdMetaNavigation)
                    .WithMany(p => p.ProyectoPnbv)
                    .HasForeignKey(d => d.IdMeta)
                    .HasConstraintName("proyecto_pnbv_meta_pnbv_fkey");

                entity.HasOne(d => d.IdObjetivoNavigation)
                    .WithMany(p => p.ProyectoPnbv)
                    .HasForeignKey(d => d.IdObjetivo)
                    .HasConstraintName("proyecto_pnbv_objetivo_pnbv_fkey");

                entity.HasOne(d => d.IdPoliticaNavigation)
                    .WithMany(p => p.ProyectoPnbv)
                    .HasForeignKey(d => d.IdPolitica)
                    .HasConstraintName("proyecto_pnbv_politica_pnbv_fkey");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoPnbv)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_pnbv_fkey");
            });

            modelBuilder.Entity<ProyectoSubsectorSenplades>(entity =>
            {
                entity.HasKey(e => e.IdProyectoSubsectorSenplades);

                entity.ToTable("proyecto_subsector_senplades", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoSubsectorSenplades)
                    .HasColumnName("id_proyecto_subsector_senplades")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_sector_id_proyecto_sector_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IdSubsectorSenplades).HasColumnName("id_subsector_senplades");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoSubsectorSenplades)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_sector");

                entity.HasOne(d => d.IdSubsectorSenpladesNavigation)
                    .WithMany(p => p.ProyectoSubsectorSenplades)
                    .HasForeignKey(d => d.IdSubsectorSenplades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_subsector_senplades_subsector_senplades_fkey");
            });

            modelBuilder.Entity<ProyectoUbicacion>(entity =>
            {
                entity.HasKey(e => e.IdProyectoUbicacion);

                entity.ToTable("proyecto_ubicacion", "proyectos_cfnr");

                entity.Property(e => e.IdProyectoUbicacion)
                    .HasColumnName("id_proyecto_ubicacion")
                    .HasDefaultValueSql("nextval('proyectos_cfnr.proyecto_ubicacion_id_proyecto_ubicacion_seq'::regclass)");

                entity.Property(e => e.CoordenadasUtmx)
                    .HasColumnName("coordenadas_utmx")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.CoordenadasUtmy)
                    .HasColumnName("coordenadas_utmy")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCanton).HasColumnName("id_canton");

                entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");

                entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");

                entity.Property(e => e.IdProyecto).HasColumnName("id_proyecto");

                entity.Property(e => e.IsNacional).HasColumnName("is_nacional");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.ProyectoUbicacion)
                    .HasForeignKey(d => d.IdCanton)
                    .HasConstraintName("canton_provincia_ubicacion_fkey");

                entity.HasOne(d => d.IdParroquiaNavigation)
                    .WithMany(p => p.ProyectoUbicacion)
                    .HasForeignKey(d => d.IdParroquia)
                    .HasConstraintName("parroquia_proyecto_ubicacion");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.ProyectoUbicacion)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("provincia_proyecto_ubicacion_fkey");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.ProyectoUbicacion)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_proyecto_ubicacion_fkey");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.ToTable("region", "comun");

                entity.Property(e => e.IdRegion)
                    .HasColumnName("id_region")
                    .HasDefaultValueSql("nextval('comun.region_id_region_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<RegistroCivil>(entity =>
            {
                entity.HasKey(e => e.RcId);

                entity.ToTable("registro_civil", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rc_fk");

                entity.HasIndex(e => e.RcId)
                    .HasName("registro_civil_pk")
                    .IsUnique();

                entity.Property(e => e.RcId)
                    .HasColumnName("rc_id")
                    .HasDefaultValueSql("nextval('interoperador.registro_civil_rc_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RcActaDefuncion).HasColumnName("rc_acta_defuncion");

                entity.Property(e => e.RcActaMatrimonio).HasColumnName("rc_acta_matrimonio");

                entity.Property(e => e.RcAnioInscripcionNacimiento).HasColumnName("rc_anio_inscripcion_nacimiento");

                entity.Property(e => e.RcCondicionCedulado)
                    .IsRequired()
                    .HasColumnName("rc_condicion_cedulado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RcEstadoCivil)
                    .IsRequired()
                    .HasColumnName("rc_estado_civil")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RcFechaDefuncion)
                    .HasColumnName("rc_fecha_defuncion")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaExpedicionCedula)
                    .HasColumnName("rc_fecha_expedicion_cedula")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaExpiracionCedula)
                    .HasColumnName("rc_fecha_expiracion_cedula")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaInscripcionDefuncion)
                    .HasColumnName("rc_fecha_inscripcion_defuncion")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaNacimiento)
                    .HasColumnName("rc_fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.RcIsActivo).HasColumnName("rc_is_activo");

                entity.Property(e => e.RcLugarFallecimiento)
                    .HasColumnName("rc_lugar_fallecimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcLugarInscripcionNacimiento)
                    .IsRequired()
                    .HasColumnName("rc_lugar_inscripcion_nacimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcLugarNacimiento)
                    .IsRequired()
                    .HasColumnName("rc_lugar_nacimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcNombreApellidoConyuge)
                    .HasColumnName("rc_nombre_apellido_conyuge")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcNumeroCedulaConyuge)
                    .HasColumnName("rc_numero_cedula_conyuge")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.RcProfesion)
                    .HasColumnName("rc_profesion")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RegistroCivil)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_registro_fk_dp_rc_datos_pr");
            });

            modelBuilder.Entity<RegistroCivil1>(entity =>
            {
                entity.HasKey(e => e.RcId);

                entity.ToTable("registro_civil");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rc_fk");

                entity.HasIndex(e => e.RcId)
                    .HasName("registro_civil_pk")
                    .IsUnique();

                entity.Property(e => e.RcId).HasColumnName("rc_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RcActaDefuncion).HasColumnName("rc_acta_defuncion");

                entity.Property(e => e.RcActaMatrimonio).HasColumnName("rc_acta_matrimonio");

                entity.Property(e => e.RcAnioInscripcionNacimiento).HasColumnName("rc_anio_inscripcion_nacimiento");

                entity.Property(e => e.RcCondicionCedulado)
                    .IsRequired()
                    .HasColumnName("rc_condicion_cedulado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RcEstadoCivil)
                    .IsRequired()
                    .HasColumnName("rc_estado_civil")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RcFechaDefuncion)
                    .HasColumnName("rc_fecha_defuncion")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaExpedicionCedula)
                    .HasColumnName("rc_fecha_expedicion_cedula")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaExpiracionCedula)
                    .HasColumnName("rc_fecha_expiracion_cedula")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaInscripcionDefuncion)
                    .HasColumnName("rc_fecha_inscripcion_defuncion")
                    .HasColumnType("date");

                entity.Property(e => e.RcFechaNacimiento)
                    .HasColumnName("rc_fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.RcIsActivo).HasColumnName("rc_is_activo");

                entity.Property(e => e.RcLugarFallecimiento)
                    .HasColumnName("rc_lugar_fallecimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcLugarInscripcionNacimiento)
                    .IsRequired()
                    .HasColumnName("rc_lugar_inscripcion_nacimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcLugarNacimiento)
                    .IsRequired()
                    .HasColumnName("rc_lugar_nacimiento")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcNombreApellidoConyuge)
                    .HasColumnName("rc_nombre_apellido_conyuge")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RcNumeroCedulaConyuge)
                    .HasColumnName("rc_numero_cedula_conyuge")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.RcProfesion)
                    .HasColumnName("rc_profesion")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RegistroCivil1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_registro_fk_dp_rc_datos_pr");
            });

            modelBuilder.Entity<RegistroPropiedad>(entity =>
            {
                entity.HasKey(e => e.RpId);

                entity.ToTable("registro_propiedad");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rp_fk");

                entity.HasIndex(e => e.RpId)
                    .HasName("registro_propiedad_pk")
                    .IsUnique();

                entity.Property(e => e.RpId).HasColumnName("rp_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RpCanton)
                    .IsRequired()
                    .HasColumnName("rp_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpClaveCatastral)
                    .HasColumnName("rp_clave_catastral")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpContraparte)
                    .HasColumnName("rp_contraparte")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RpCuantia)
                    .HasColumnName("rp_cuantia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpFechaInscripcion)
                    .HasColumnName("rp_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.RpIsActivo).HasColumnName("rp_is_activo");

                entity.Property(e => e.RpParroquia)
                    .IsRequired()
                    .HasColumnName("rp_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpTipoContrato)
                    .IsRequired()
                    .HasColumnName("rp_tipo_contrato")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpUbicacion)
                    .IsRequired()
                    .HasColumnName("rp_ubicacion")
                    .HasColumnType("character varying(100)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RegistroPropiedad)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_registro_fk_dp_rp_datos_pr");
            });

            modelBuilder.Entity<RegistroPropiedad1>(entity =>
            {
                entity.HasKey(e => e.RpId);

                entity.ToTable("registro_propiedad", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rp_fk");

                entity.HasIndex(e => e.RpId)
                    .HasName("registro_propiedad_pk")
                    .IsUnique();

                entity.Property(e => e.RpId)
                    .HasColumnName("rp_id")
                    .HasDefaultValueSql("nextval('interoperador.registro_propiedad_rp_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RpCanton)
                    .IsRequired()
                    .HasColumnName("rp_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpClaveCatastral)
                    .HasColumnName("rp_clave_catastral")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpContraparte)
                    .HasColumnName("rp_contraparte")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RpCuantia)
                    .HasColumnName("rp_cuantia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpFechaInscripcion)
                    .HasColumnName("rp_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.RpIsActivo).HasColumnName("rp_is_activo");

                entity.Property(e => e.RpParroquia)
                    .IsRequired()
                    .HasColumnName("rp_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpTipoContrato)
                    .IsRequired()
                    .HasColumnName("rp_tipo_contrato")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RpUbicacion)
                    .IsRequired()
                    .HasColumnName("rp_ubicacion")
                    .HasColumnType("character varying(100)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RegistroPropiedad1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_registro_fk_dp_rp_datos_pr");
            });

            modelBuilder.Entity<RmContratos>(entity =>
            {
                entity.HasKey(e => e.RmcId);

                entity.ToTable("rm_contratos");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rmc_fk");

                entity.HasIndex(e => e.RmcId)
                    .HasName("rm_contratos_pk")
                    .IsUnique();

                entity.Property(e => e.RmcId).HasColumnName("rmc_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RmcActMerRegCompania)
                    .HasColumnName("rmc_act_mer_reg_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcActMerRegFechaInscr)
                    .HasColumnName("rmc_act_mer_reg_fecha_inscr")
                    .HasColumnType("date");

                entity.Property(e => e.RmcActMerRegNumeroInscr).HasColumnName("rmc_act_mer_reg_numero_inscr");

                entity.Property(e => e.RmcActMerRegRepresentante)
                    .HasColumnName("rmc_act_mer_reg_representante")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcActMerRegiTipoContrato)
                    .HasColumnName("rmc_act_mer_regi_tipo_contrato")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcIsActivo).HasColumnName("rmc_is_activo");

                entity.Property(e => e.RmcResDomPrenAnioFabr).HasColumnName("rmc_res_dom_pren_anio_fabr");

                entity.Property(e => e.RmcResDomPrenChasisOSerie)
                    .HasColumnName("rmc_res_dom_pren_chasis_o_serie")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenMarca)
                    .HasColumnName("rmc_res_dom_pren_marca")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenModelo)
                    .HasColumnName("rmc_res_dom_pren_modelo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenMotor)
                    .HasColumnName("rmc_res_dom_pren_motor")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenPlaca)
                    .HasColumnName("rmc_res_dom_pren_placa")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RmContratos)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rm_contr_fk_dp_rmc_datos_pr");
            });

            modelBuilder.Entity<RmContratos1>(entity =>
            {
                entity.HasKey(e => e.RmcId);

                entity.ToTable("rm_contratos", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_rmc_fk");

                entity.HasIndex(e => e.RmcId)
                    .HasName("rm_contratos_pk")
                    .IsUnique();

                entity.Property(e => e.RmcId)
                    .HasColumnName("rmc_id")
                    .HasDefaultValueSql("nextval('interoperador.rm_contratos_rmc_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RmcActMerRegCompania)
                    .HasColumnName("rmc_act_mer_reg_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcActMerRegFechaInscr)
                    .HasColumnName("rmc_act_mer_reg_fecha_inscr")
                    .HasColumnType("date");

                entity.Property(e => e.RmcActMerRegNumeroInscr).HasColumnName("rmc_act_mer_reg_numero_inscr");

                entity.Property(e => e.RmcActMerRegRepresentante)
                    .HasColumnName("rmc_act_mer_reg_representante")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcActMerRegiTipoContrato)
                    .HasColumnName("rmc_act_mer_regi_tipo_contrato")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcIsActivo).HasColumnName("rmc_is_activo");

                entity.Property(e => e.RmcResDomPrenAnioFabr).HasColumnName("rmc_res_dom_pren_anio_fabr");

                entity.Property(e => e.RmcResDomPrenChasisOSerie)
                    .HasColumnName("rmc_res_dom_pren_chasis_o_serie")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenMarca)
                    .HasColumnName("rmc_res_dom_pren_marca")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenModelo)
                    .HasColumnName("rmc_res_dom_pren_modelo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenMotor)
                    .HasColumnName("rmc_res_dom_pren_motor")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmcResDomPrenPlaca)
                    .HasColumnName("rmc_res_dom_pren_placa")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RmContratos1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rm_contr_fk_dp_rmc_datos_pr");
            });

            modelBuilder.Entity<RmSocietarios>(entity =>
            {
                entity.HasKey(e => e.RmActSocId);

                entity.ToTable("rm_societarios");

                entity.HasIndex(e => e.DpId)
                    .HasName("relationship_8_fk");

                entity.HasIndex(e => e.RmActSocId)
                    .HasName("rm_societarios_pk")
                    .IsUnique();

                entity.Property(e => e.RmActSocId).HasColumnName("rm_act_soc_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RmActSocApellidosAdmin)
                    .HasColumnName("rm_act_soc_apellidos_admin")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocCargo)
                    .HasColumnName("rm_act_soc_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocCedulaAdmin)
                    .HasColumnName("rm_act_soc_cedula_admin")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.RmActSocFechaEscritura)
                    .HasColumnName("rm_act_soc_fecha_escritura")
                    .HasColumnType("date");

                entity.Property(e => e.RmActSocFechaInscripcion)
                    .HasColumnName("rm_act_soc_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.RmActSocIsActivo).HasColumnName("rm_act_soc_is_activo");

                entity.Property(e => e.RmActSocNombreCompania)
                    .HasColumnName("rm_act_soc_nombre_compania")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RmActSocNombresAdmin)
                    .HasColumnName("rm_act_soc_nombres_admin")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocNotaria)
                    .HasColumnName("rm_act_soc_notaria")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocRuc)
                    .HasColumnName("rm_act_soc_ruc")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.RmActSocTipoCompania)
                    .HasColumnName("rm_act_soc_tipo_compania")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RmSocietarios)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rm_socie_relations_datos_pr");
            });

            modelBuilder.Entity<RmSocietarios1>(entity =>
            {
                entity.HasKey(e => e.RmActSocId);

                entity.ToTable("rm_societarios", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("relationship_8_fk");

                entity.HasIndex(e => e.RmActSocId)
                    .HasName("rm_societarios_pk")
                    .IsUnique();

                entity.Property(e => e.RmActSocId)
                    .HasColumnName("rm_act_soc_id")
                    .HasDefaultValueSql("nextval('interoperador.rm_societarios_rm_act_soc_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.RmActSocApellidosAdmin)
                    .HasColumnName("rm_act_soc_apellidos_admin")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocCargo)
                    .HasColumnName("rm_act_soc_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocCedulaAdmin)
                    .HasColumnName("rm_act_soc_cedula_admin")
                    .HasColumnType("character varying(10)");

                entity.Property(e => e.RmActSocFechaEscritura)
                    .HasColumnName("rm_act_soc_fecha_escritura")
                    .HasColumnType("date");

                entity.Property(e => e.RmActSocFechaInscripcion)
                    .HasColumnName("rm_act_soc_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.RmActSocIsActivo).HasColumnName("rm_act_soc_is_activo");

                entity.Property(e => e.RmActSocNombreCompania)
                    .HasColumnName("rm_act_soc_nombre_compania")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.RmActSocNombresAdmin)
                    .HasColumnName("rm_act_soc_nombres_admin")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocNotaria)
                    .HasColumnName("rm_act_soc_notaria")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.RmActSocRuc)
                    .HasColumnName("rm_act_soc_ruc")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.RmActSocTipoCompania)
                    .HasColumnName("rm_act_soc_tipo_compania")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.RmSocietarios1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rm_socie_relations_datos_pr");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("rol", "seguridad");

                entity.HasIndex(e => e.IdGrupoRol)
                    .HasName("rol_gruporol_fk");

                entity.HasIndex(e => e.IdRol)
                    .HasName("rol_pk")
                    .IsUnique();

                entity.HasIndex(e => e.IdSistema)
                    .HasName("rol_sistema_fk");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasDefaultValueSql("nextval('seguridad.rol_id_rol_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdGrupoRol).HasColumnName("id_grupo_rol");

                entity.Property(e => e.IdSistema).HasColumnName("id_sistema");

                entity.Property(e => e.IsAcivo).HasColumnName("is_acivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdGrupoRolNavigation)
                    .WithMany(p => p.Rol)
                    .HasForeignKey(d => d.IdGrupoRol)
                    .HasConstraintName("fk_rol_rol_grupo_gruporol");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.Rol)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rol_rol_siste_sistema");
            });

            modelBuilder.Entity<SecapCursos>(entity =>
            {
                entity.HasKey(e => e.SecId);

                entity.ToTable("secap_cursos");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sec_fk");

                entity.HasIndex(e => e.SecId)
                    .HasName("secap_cursos_pk")
                    .IsUnique();

                entity.Property(e => e.SecId).HasColumnName("sec_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SecArea)
                    .IsRequired()
                    .HasColumnName("sec_area")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SecDuracionDias).HasColumnName("sec_duracion_dias");

                entity.Property(e => e.SecDuracionHoras).HasColumnName("sec_duracion_horas");

                entity.Property(e => e.SecEstadoAcademico)
                    .IsRequired()
                    .HasColumnName("sec_estado_academico")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecFechaFin)
                    .HasColumnName("sec_fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.SecFechaInicio)
                    .HasColumnName("sec_fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.SecFechaInscripcion)
                    .HasColumnName("sec_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.SecIsActivo).HasColumnName("sec_is_activo");

                entity.Property(e => e.SecLugarEjecucion)
                    .IsRequired()
                    .HasColumnName("sec_lugar_ejecucion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecModalidad)
                    .IsRequired()
                    .HasColumnName("sec_modalidad")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecNombre)
                    .IsRequired()
                    .HasColumnName("sec_nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SecProcesoFormativo)
                    .IsRequired()
                    .HasColumnName("sec_proceso_formativo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecSectorEconomico)
                    .IsRequired()
                    .HasColumnName("sec_sector_economico")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecTipoCertificado)
                    .IsRequired()
                    .HasColumnName("sec_tipo_certificado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecValor).HasColumnName("sec_valor");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.SecapCursos)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_secap_cu_fk_dp_sec_datos_pr");
            });

            modelBuilder.Entity<SecapCursos1>(entity =>
            {
                entity.HasKey(e => e.SecId);

                entity.ToTable("secap_cursos", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sec_fk");

                entity.HasIndex(e => e.SecId)
                    .HasName("secap_cursos_pk")
                    .IsUnique();

                entity.Property(e => e.SecId)
                    .HasColumnName("sec_id")
                    .HasDefaultValueSql("nextval('interoperador.secap_cursos_sec_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SecArea)
                    .IsRequired()
                    .HasColumnName("sec_area")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SecDuracionDias).HasColumnName("sec_duracion_dias");

                entity.Property(e => e.SecDuracionHoras).HasColumnName("sec_duracion_horas");

                entity.Property(e => e.SecEstadoAcademico)
                    .IsRequired()
                    .HasColumnName("sec_estado_academico")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecFechaFin)
                    .HasColumnName("sec_fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.SecFechaInicio)
                    .HasColumnName("sec_fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.SecFechaInscripcion)
                    .HasColumnName("sec_fecha_inscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.SecIsActivo).HasColumnName("sec_is_activo");

                entity.Property(e => e.SecLugarEjecucion)
                    .IsRequired()
                    .HasColumnName("sec_lugar_ejecucion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecModalidad)
                    .IsRequired()
                    .HasColumnName("sec_modalidad")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecNombre)
                    .IsRequired()
                    .HasColumnName("sec_nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SecProcesoFormativo)
                    .IsRequired()
                    .HasColumnName("sec_proceso_formativo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecSectorEconomico)
                    .IsRequired()
                    .HasColumnName("sec_sector_economico")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecTipoCertificado)
                    .IsRequired()
                    .HasColumnName("sec_tipo_certificado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SecValor).HasColumnName("sec_valor");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.SecapCursos1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_secap_cu_fk_dp_sec_datos_pr");
            });

            modelBuilder.Entity<SectorSenplades>(entity =>
            {
                entity.HasKey(e => e.IdSectorSenplades);

                entity.ToTable("sector_senplades", "catalogos_externos");

                entity.Property(e => e.IdSectorSenplades)
                    .HasColumnName("id_sector_senplades")
                    .HasDefaultValueSql("nextval('catalogos_externos.sector_senplades_id_sector_senplades_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdMacrosectorSenplades).HasColumnName("id_macrosector_senplades");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdMacrosectorSenpladesNavigation)
                    .WithMany(p => p.SectorSenplades)
                    .HasForeignKey(d => d.IdMacrosectorSenplades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("macrosector_senplades_sector_senplades_fkey");
            });

            modelBuilder.Entity<Senescyt>(entity =>
            {
                entity.HasKey(e => e.SncId);

                entity.ToTable("senescyt");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_snc_fk");

                entity.HasIndex(e => e.SncId)
                    .HasName("senescyt_pk")
                    .IsUnique();

                entity.Property(e => e.SncId).HasColumnName("snc_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SncAreaCodigo).HasColumnName("snc_area_codigo");

                entity.Property(e => e.SncAreaEstudio)
                    .HasColumnName("snc_area_estudio")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SncCodRegTitCiudadano)
                    .IsRequired()
                    .HasColumnName("snc_cod_reg_tit_ciudadano")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SncFechaRegTitCiudadano)
                    .HasColumnName("snc_fecha_reg_tit_ciudadano")
                    .HasColumnType("date");

                entity.Property(e => e.SncIsActivo).HasColumnName("snc_is_activo");

                entity.Property(e => e.SncNombreIes)
                    .IsRequired()
                    .HasColumnName("snc_nombre_ies")
                    .HasColumnType("character varying(100)")
                    .ForNpgsqlHasComment("IES: Institución de Educación Superior");

                entity.Property(e => e.SncNombreTitCiudadano)
                    .IsRequired()
                    .HasColumnName("snc_nombre_tit_ciudadano")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SncSubareaCodigo).HasColumnName("snc_subarea_codigo");

                entity.Property(e => e.SncSubareaEstudio)
                    .HasColumnName("snc_subarea_estudio")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SncTipo)
                    .IsRequired()
                    .HasColumnName("snc_tipo")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Senescyt)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_senescyt_fk_dp_snc_datos_pr");
            });

            modelBuilder.Entity<Senescyt1>(entity =>
            {
                entity.HasKey(e => e.SncId);

                entity.ToTable("senescyt", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_snc_fk");

                entity.HasIndex(e => e.SncId)
                    .HasName("senescyt_pk")
                    .IsUnique();

                entity.Property(e => e.SncId)
                    .HasColumnName("snc_id")
                    .HasDefaultValueSql("nextval('interoperador.senescyt_snc_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SncAreaCodigo).HasColumnName("snc_area_codigo");

                entity.Property(e => e.SncAreaEstudio)
                    .HasColumnName("snc_area_estudio")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SncCodRegTitCiudadano)
                    .IsRequired()
                    .HasColumnName("snc_cod_reg_tit_ciudadano")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SncFechaRegTitCiudadano)
                    .HasColumnName("snc_fecha_reg_tit_ciudadano")
                    .HasColumnType("date");

                entity.Property(e => e.SncIsActivo).HasColumnName("snc_is_activo");

                entity.Property(e => e.SncNombreIes)
                    .IsRequired()
                    .HasColumnName("snc_nombre_ies")
                    .HasColumnType("character varying(100)")
                    .ForNpgsqlHasComment("IES: Institución de Educación Superior");

                entity.Property(e => e.SncNombreTitCiudadano)
                    .IsRequired()
                    .HasColumnName("snc_nombre_tit_ciudadano")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SncSubareaCodigo).HasColumnName("snc_subarea_codigo");

                entity.Property(e => e.SncSubareaEstudio)
                    .HasColumnName("snc_subarea_estudio")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SncTipo)
                    .IsRequired()
                    .HasColumnName("snc_tipo")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Senescyt1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_senescyt_fk_dp_snc_datos_pr");
            });

            modelBuilder.Entity<Seps>(entity =>
            {
                entity.HasKey(e => e.SepId);

                entity.ToTable("seps");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sep_fk");

                entity.HasIndex(e => e.SepId)
                    .HasName("seps_pk")
                    .IsUnique();

                entity.Property(e => e.SepId).HasColumnName("sep_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SepCalle)
                    .HasColumnName("sep_calle")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepCanton)
                    .HasColumnName("sep_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepClaseOrganizacion)
                    .HasColumnName("sep_clase_organizacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepEstadoOrganizacion)
                    .HasColumnName("sep_estado_organizacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepFechaRegistro)
                    .HasColumnName("sep_fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.SepInterseccion)
                    .HasColumnName("sep_interseccion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepIsActivo).HasColumnName("sep_is_activo");

                entity.Property(e => e.SepNombreRepresentanteLegal)
                    .HasColumnName("sep_nombre_representante_legal")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SepNombreSecretario)
                    .HasColumnName("sep_nombre_secretario")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepNumero).HasColumnName("sep_numero");

                entity.Property(e => e.SepNumeroResolucion).HasColumnName("sep_numero_resolucion");

                entity.Property(e => e.SepParroquia)
                    .HasColumnName("sep_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepProvincia)
                    .HasColumnName("sep_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepRazonSocial)
                    .HasColumnName("sep_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SepTipoOrganizacion)
                    .HasColumnName("sep_tipo_organizacion")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Seps)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seps_fk_dp_sep_datos_pr");
            });

            modelBuilder.Entity<Seps1>(entity =>
            {
                entity.HasKey(e => e.SepId);

                entity.ToTable("seps", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sep_fk");

                entity.HasIndex(e => e.SepId)
                    .HasName("seps_pk")
                    .IsUnique();

                entity.Property(e => e.SepId)
                    .HasColumnName("sep_id")
                    .HasDefaultValueSql("nextval('interoperador.seps_sep_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SepCalle)
                    .HasColumnName("sep_calle")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepCanton)
                    .HasColumnName("sep_canton")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepClaseOrganizacion)
                    .HasColumnName("sep_clase_organizacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepEstadoOrganizacion)
                    .HasColumnName("sep_estado_organizacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepFechaRegistro)
                    .HasColumnName("sep_fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.SepInterseccion)
                    .HasColumnName("sep_interseccion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepIsActivo).HasColumnName("sep_is_activo");

                entity.Property(e => e.SepNombreRepresentanteLegal)
                    .HasColumnName("sep_nombre_representante_legal")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SepNombreSecretario)
                    .HasColumnName("sep_nombre_secretario")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepNumero)
                    .HasColumnName("sep_numero")
                    .HasColumnType("character varying(25)");

                entity.Property(e => e.SepNumeroResolucion)
                    .HasColumnName("sep_numero_resolucion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepParroquia)
                    .HasColumnName("sep_parroquia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepProvincia)
                    .HasColumnName("sep_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SepRazonSocial)
                    .HasColumnName("sep_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SepTipoOrganizacion)
                    .HasColumnName("sep_tipo_organizacion")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Seps1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seps_fk_dp_sep_datos_pr");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.WsCodigo);

                entity.ToTable("servicio");

                entity.HasIndex(e => e.WsCodigo)
                    .HasName("servicio_pk")
                    .IsUnique();

                entity.Property(e => e.WsCodigo)
                    .HasColumnName("ws_codigo")
                    .ValueGeneratedNever()
                    .ForNpgsqlHasComment("Código del paquete proporcionado por la DINARDAP");

                entity.Property(e => e.WsInstitucion)
                    .IsRequired()
                    .HasColumnName("ws_institucion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsIsActivo).HasColumnName("ws_is_activo");

                entity.Property(e => e.WsNombre)
                    .IsRequired()
                    .HasColumnName("ws_nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsUrl)
                    .IsRequired()
                    .HasColumnName("ws_url")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsVersion).HasColumnName("ws_version");
            });

            modelBuilder.Entity<Servicio1>(entity =>
            {
                entity.HasKey(e => e.WsCodigo);

                entity.ToTable("servicio", "interoperador");

                entity.HasIndex(e => e.WsCodigo)
                    .HasName("servicio_pk")
                    .IsUnique();

                entity.Property(e => e.WsCodigo)
                    .HasColumnName("ws_codigo")
                    .ValueGeneratedNever()
                    .ForNpgsqlHasComment("Código del paquete proporcionado por la DINARDAP");

                entity.Property(e => e.WsInstitucion)
                    .IsRequired()
                    .HasColumnName("ws_institucion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsIsActivo).HasColumnName("ws_is_activo");

                entity.Property(e => e.WsNombre)
                    .IsRequired()
                    .HasColumnName("ws_nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsUrl)
                    .IsRequired()
                    .HasColumnName("ws_url")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.WsVersion).HasColumnName("ws_version");
            });

            modelBuilder.Entity<Sistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema);

                entity.ToTable("sistema", "seguridad");

                entity.HasIndex(e => e.IdSistema)
                    .HasName("sistema_pk")
                    .IsUnique();

                entity.Property(e => e.IdSistema)
                    .HasColumnName("id_sistema")
                    .HasDefaultValueSql("nextval('seguridad.sistema_id_sistema_seq'::regclass)");

                entity.Property(e => e.Ambiente)
                    .IsRequired()
                    .HasColumnName("ambiente")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.IsInterno)
                    .HasColumnName("is_interno")
                    .ForNpgsqlHasComment("Si campo es true el usuario es interno, caso contrario es externo");

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Puerto)
                    .IsRequired()
                    .HasColumnName("puerto")
                    .HasColumnType("character varying(5)");

                entity.Property(e => e.Servidor)
                    .IsRequired()
                    .HasColumnName("servidor")
                    .HasColumnType("character varying(15)");

                entity.Property(e => e.Siglas)
                    .IsRequired()
                    .HasColumnName("siglas")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("character varying(250)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.Entity<Sri>(entity =>
            {
                entity.HasKey(e => e.SriRucId);

                entity.ToTable("sri");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sri_fk");

                entity.HasIndex(e => e.SriRucId)
                    .HasName("sri_pk")
                    .IsUnique();

                entity.Property(e => e.SriRucId).HasColumnName("sri_ruc_id");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SriActEcoActGeneral)
                    .IsRequired()
                    .HasColumnName("sri_act_eco_act_general")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoCod)
                    .HasColumnName("sri_act_eco_cod")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN1Fam)
                    .HasColumnName("sri_act_eco_cod_n1_fam")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN2Grp)
                    .HasColumnName("sri_act_eco_cod_n2_grp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN3Subgrp)
                    .HasColumnName("sri_act_eco_cod_n3_subgrp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN4Clase)
                    .HasColumnName("sri_act_eco_cod_n4_clase")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN5Subgrp)
                    .HasColumnName("sri_act_eco_cod_n5_subgrp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN6Act)
                    .HasColumnName("sri_act_eco_cod_n6_act")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoDescN1Fam)
                    .HasColumnName("sri_act_eco_desc_n1_fam")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN2Grp)
                    .HasColumnName("sri_act_eco_desc_n2_grp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN3Subgrp)
                    .HasColumnName("sri_act_eco_desc_n3_subgrp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN4Clase)
                    .HasColumnName("sri_act_eco_desc_n4_clase")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN5Subgrp)
                    .HasColumnName("sri_act_eco_desc_n5_subgrp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN6Act)
                    .HasColumnName("sri_act_eco_desc_n6_act")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriEstrOrgCodigoProvincia)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_codigo_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgCodigoRegion)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_codigo_region")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgIdentificacion).HasColumnName("sri_estr_org_identificacion");

                entity.Property(e => e.SriEstrOrgNombreProvincia)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_nombre_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgNombreRegion)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_nombre_region")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriIsActivo).HasColumnName("sri_is_activo");

                entity.Property(e => e.SriRucActEcoPrincipal)
                    .IsRequired()
                    .HasColumnName("sri_ruc_act_eco_principal")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriRucClaseContibuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_clase_contibuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoContribuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_estado_contribuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoRucPerNat)
                    .HasColumnName("sri_ruc_estado_ruc_per_nat")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoRucSociedad)
                    .HasColumnName("sri_ruc_estado_ruc_sociedad")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucFantasiaComercial)
                    .HasColumnName("sri_ruc_fantasia_comercial")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucFechaActualizacion)
                    .HasColumnName("sri_ruc_fecha_actualizacion")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaCancelacion)
                    .HasColumnName("sri_ruc_fecha_cancelacion")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaInicioActividad)
                    .HasColumnName("sri_ruc_fecha_inicio_actividad")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaReiActividad)
                    .HasColumnName("sri_ruc_fecha_rei_actividad")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaSuspDef)
                    .HasColumnName("sri_ruc_fecha_susp_def")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucRazonSocial)
                    .IsRequired()
                    .HasColumnName("sri_ruc_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucTipoContribuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_tipo_contribuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucTipoPersona)
                    .IsRequired()
                    .HasColumnName("sri_ruc_tipo_persona")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribId).HasColumnName("sri_tipo_contrib_id");

                entity.Property(e => e.SriTipoContribNivel2)
                    .HasColumnName("sri_tipo_contrib_nivel2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribNivel3)
                    .HasColumnName("sri_tipo_contrib_nivel3")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribNivel4)
                    .HasColumnName("sri_tipo_contrib_nivel4")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribUltNivel)
                    .HasColumnName("sri_tipo_contrib_ult_nivel")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribeNivel1)
                    .HasColumnName("sri_tipo_contribe_nivel1")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Sri)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_fk_dp_sri_datos_pr");
            });

            modelBuilder.Entity<Sri1>(entity =>
            {
                entity.HasKey(e => e.SriRucId);

                entity.ToTable("sri", "interoperador");

                entity.HasIndex(e => e.DpId)
                    .HasName("fk_dp_sri_fk");

                entity.HasIndex(e => e.SriRucId)
                    .HasName("sri_pk")
                    .IsUnique();

                entity.Property(e => e.SriRucId)
                    .HasColumnName("sri_ruc_id")
                    .HasDefaultValueSql("nextval('interoperador.sri_sri_ruc_id_seq'::regclass)");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.Property(e => e.SriActEcoActGeneral)
                    .IsRequired()
                    .HasColumnName("sri_act_eco_act_general")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoCod)
                    .HasColumnName("sri_act_eco_cod")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN1Fam)
                    .HasColumnName("sri_act_eco_cod_n1_fam")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN2Grp)
                    .HasColumnName("sri_act_eco_cod_n2_grp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN3Subgrp)
                    .HasColumnName("sri_act_eco_cod_n3_subgrp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN4Clase)
                    .HasColumnName("sri_act_eco_cod_n4_clase")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN5Subgrp)
                    .HasColumnName("sri_act_eco_cod_n5_subgrp")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoCodN6Act)
                    .HasColumnName("sri_act_eco_cod_n6_act")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriActEcoDescN1Fam)
                    .HasColumnName("sri_act_eco_desc_n1_fam")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN2Grp)
                    .HasColumnName("sri_act_eco_desc_n2_grp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN3Subgrp)
                    .HasColumnName("sri_act_eco_desc_n3_subgrp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN4Clase)
                    .HasColumnName("sri_act_eco_desc_n4_clase")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN5Subgrp)
                    .HasColumnName("sri_act_eco_desc_n5_subgrp")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriActEcoDescN6Act)
                    .HasColumnName("sri_act_eco_desc_n6_act")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriEstrOrgCodigoProvincia)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_codigo_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgCodigoRegion)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_codigo_region")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgIdentificacion).HasColumnName("sri_estr_org_identificacion");

                entity.Property(e => e.SriEstrOrgNombreProvincia)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_nombre_provincia")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstrOrgNombreRegion)
                    .IsRequired()
                    .HasColumnName("sri_estr_org_nombre_region")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriIsActivo).HasColumnName("sri_is_activo");

                entity.Property(e => e.SriRucActEcoPrincipal)
                    .IsRequired()
                    .HasColumnName("sri_ruc_act_eco_principal")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriRucClaseContibuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_clase_contibuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoContribuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_estado_contribuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoRucPerNat)
                    .HasColumnName("sri_ruc_estado_ruc_per_nat")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucEstadoRucSociedad)
                    .HasColumnName("sri_ruc_estado_ruc_sociedad")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucFantasiaComercial)
                    .HasColumnName("sri_ruc_fantasia_comercial")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucFechaActualizacion)
                    .HasColumnName("sri_ruc_fecha_actualizacion")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaCancelacion)
                    .HasColumnName("sri_ruc_fecha_cancelacion")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaInicioActividad)
                    .HasColumnName("sri_ruc_fecha_inicio_actividad")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaReiActividad)
                    .HasColumnName("sri_ruc_fecha_rei_actividad")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucFechaSuspDef)
                    .HasColumnName("sri_ruc_fecha_susp_def")
                    .HasColumnType("date");

                entity.Property(e => e.SriRucRazonSocial)
                    .IsRequired()
                    .HasColumnName("sri_ruc_razon_social")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucTipoContribuyente)
                    .IsRequired()
                    .HasColumnName("sri_ruc_tipo_contribuyente")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucTipoPersona)
                    .IsRequired()
                    .HasColumnName("sri_ruc_tipo_persona")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribId).HasColumnName("sri_tipo_contrib_id");

                entity.Property(e => e.SriTipoContribNivel2)
                    .HasColumnName("sri_tipo_contrib_nivel2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribNivel3)
                    .HasColumnName("sri_tipo_contrib_nivel3")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribNivel4)
                    .HasColumnName("sri_tipo_contrib_nivel4")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribUltNivel)
                    .HasColumnName("sri_tipo_contrib_ult_nivel")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriTipoContribeNivel1)
                    .HasColumnName("sri_tipo_contribe_nivel1")
                    .HasColumnType("character varying(50)");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Sri1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_fk_dp_sri_datos_pr");
            });

            modelBuilder.Entity<SriEstablecimientos>(entity =>
            {
                entity.HasKey(e => e.SriEstId);

                entity.ToTable("sri_establecimientos", "interoperador");

                entity.HasIndex(e => e.SriEstId)
                    .HasName("sri_establecimientos_pk")
                    .IsUnique();

                entity.HasIndex(e => e.SriRucId)
                    .HasName("fk_sri_est_fk");

                entity.Property(e => e.SriEstId)
                    .HasColumnName("sri_est_id")
                    .HasDefaultValueSql("nextval('interoperador.sri_establecimientos_sri_est_id_seq'::regclass)");

                entity.Property(e => e.SriEstActividadEconomica)
                    .HasColumnName("sri_est_actividad_economica")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriEstCalle)
                    .HasColumnName("sri_est_calle")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstDireccionNumero)
                    .HasColumnName("sri_est_direccion_numero")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstEstado)
                    .IsRequired()
                    .HasColumnName("sri_est_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstFantasiaComercial)
                    .HasColumnName("sri_est_fantasia_comercial")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstInterseccion)
                    .HasColumnName("sri_est_interseccion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstIsActivo).HasColumnName("sri_est_is_activo");

                entity.Property(e => e.SriEstNumero).HasColumnName("sri_est_numero");

                entity.Property(e => e.SriEstRuc)
                    .IsRequired()
                    .HasColumnName("sri_est_ruc")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.SriEstTipo)
                    .IsRequired()
                    .HasColumnName("sri_est_tipo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstUbicacionGeografica)
                    .HasColumnName("sri_est_ubicacion_geografica")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucId).HasColumnName("sri_ruc_id");

                entity.HasOne(d => d.SriRuc)
                    .WithMany(p => p.SriEstablecimientos)
                    .HasForeignKey(d => d.SriRucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_esta_fk_sri_es_sri");
            });

            modelBuilder.Entity<SriEstablecimientos1>(entity =>
            {
                entity.HasKey(e => e.SriEstId);

                entity.ToTable("sri_establecimientos");

                entity.HasIndex(e => e.SriEstId)
                    .HasName("sri_establecimientos_pk")
                    .IsUnique();

                entity.HasIndex(e => e.SriRucId)
                    .HasName("fk_sri_est_fk");

                entity.Property(e => e.SriEstId).HasColumnName("sri_est_id");

                entity.Property(e => e.SriEstActividadEconomica)
                    .HasColumnName("sri_est_actividad_economica")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.SriEstCalle)
                    .HasColumnName("sri_est_calle")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstDireccionNumero)
                    .HasColumnName("sri_est_direccion_numero")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstEstado)
                    .IsRequired()
                    .HasColumnName("sri_est_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstFantasiaComercial)
                    .HasColumnName("sri_est_fantasia_comercial")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstInterseccion)
                    .HasColumnName("sri_est_interseccion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstIsActivo).HasColumnName("sri_est_is_activo");

                entity.Property(e => e.SriEstNumero).HasColumnName("sri_est_numero");

                entity.Property(e => e.SriEstRuc)
                    .IsRequired()
                    .HasColumnName("sri_est_ruc")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.SriEstTipo)
                    .IsRequired()
                    .HasColumnName("sri_est_tipo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstUbicacionGeografica)
                    .HasColumnName("sri_est_ubicacion_geografica")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriRucId).HasColumnName("sri_ruc_id");

                entity.HasOne(d => d.SriRuc)
                    .WithMany(p => p.SriEstablecimientos1)
                    .HasForeignKey(d => d.SriRucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_esta_fk_sri_es_sri");
            });

            modelBuilder.Entity<SriEstadosTributarios>(entity =>
            {
                entity.HasKey(e => e.SriEstTributarioId);

                entity.ToTable("sri_estados_tributarios");

                entity.HasIndex(e => e.SriEstTributarioId)
                    .HasName("sri_estados_tributarios_pk")
                    .IsUnique();

                entity.HasIndex(e => e.SriRucId)
                    .HasName("fk_sri_tri_fk");

                entity.Property(e => e.SriEstTributarioId).HasColumnName("sri_est_tributario_id");

                entity.Property(e => e.SriEstTributarioDescripcion)
                    .HasColumnName("sri_est_tributario_descripcion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstTributarioEstado)
                    .HasColumnName("sri_est_tributario_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstTributarioIsActivo).HasColumnName("sri_est_tributario_is_activo");

                entity.Property(e => e.SriEstTributarioMotivo)
                    .HasColumnName("sri_est_tributario_motivo")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucId).HasColumnName("sri_ruc_id");

                entity.HasOne(d => d.SriRuc)
                    .WithMany(p => p.SriEstadosTributarios)
                    .HasForeignKey(d => d.SriRucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_esta_fk_sri_tr_sri");
            });

            modelBuilder.Entity<SriEstadosTributarios1>(entity =>
            {
                entity.HasKey(e => e.SriEstTributarioId);

                entity.ToTable("sri_estados_tributarios", "interoperador");

                entity.HasIndex(e => e.SriEstTributarioId)
                    .HasName("sri_estados_tributarios_pk")
                    .IsUnique();

                entity.HasIndex(e => e.SriRucId)
                    .HasName("fk_sri_tri_fk");

                entity.Property(e => e.SriEstTributarioId)
                    .HasColumnName("sri_est_tributario_id")
                    .HasDefaultValueSql("nextval('interoperador.sri_estados_tributarios_sri_est_tributario_id_seq'::regclass)");

                entity.Property(e => e.SriEstTributarioDescripcion)
                    .HasColumnName("sri_est_tributario_descripcion")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriEstTributarioEstado)
                    .HasColumnName("sri_est_tributario_estado")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.SriEstTributarioIsActivo).HasColumnName("sri_est_tributario_is_activo");

                entity.Property(e => e.SriEstTributarioMotivo)
                    .HasColumnName("sri_est_tributario_motivo")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.SriRucId).HasColumnName("sri_ruc_id");

                entity.HasOne(d => d.SriRuc)
                    .WithMany(p => p.SriEstadosTributarios1)
                    .HasForeignKey(d => d.SriRucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sri_esta_fk_sri_tr_sri");
            });

            modelBuilder.Entity<SubsectorSenplades>(entity =>
            {
                entity.HasKey(e => e.IdSubsectorSenplades);

                entity.ToTable("subsector_senplades", "catalogos_externos");

                entity.Property(e => e.IdSubsectorSenplades)
                    .HasColumnName("id_subsector_senplades")
                    .HasDefaultValueSql("nextval('catalogos_externos.subsector_senplades_id_subsector_senplades_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdSectorSenplades).HasColumnName("id_sector_senplades");

                entity.Property(e => e.IsMatrizProductiva).HasColumnName("is_matriz_productiva");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdSectorSenpladesNavigation)
                    .WithMany(p => p.SubsectorSenplades)
                    .HasForeignKey(d => d.IdSectorSenplades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sector_senplades_subsector_senplades_fkey");
            });

            modelBuilder.Entity<Supercias>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("supercias", "interoperador");

                entity.HasIndex(e => e.ComId)
                    .HasName("supercias_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("sp_dp_com_fk");

                entity.Property(e => e.ComId)
                    .HasColumnName("com_id")
                    .HasDefaultValueSql("nextval('interoperador.supercias_com_id_seq'::regclass)");

                entity.Property(e => e.ComActEcoDescripcion)
                    .HasColumnName("com_act_eco_descripcion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaApartadoPostal).HasColumnName("com_cia_apartado_postal");

                entity.Property(e => e.ComCiaBarrio)
                    .HasColumnName("com_cia_barrio")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaBloque)
                    .HasColumnName("com_cia_bloque")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCallePostal)
                    .HasColumnName("com_cia_calle_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCamino)
                    .HasColumnName("com_cia_camino")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCantonLegal)
                    .HasColumnName("com_cia_canton_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCantonPostal)
                    .HasColumnName("com_cia_canton_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCapitalAutorizado)
                    .HasColumnName("com_cia_capital_autorizado")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.ComCiaCapitalPagado)
                    .HasColumnName("com_cia_capital_pagado")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.ComCiaCapitalSuscrito)
                    .HasColumnName("com_cia_capital_suscrito")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.ComCiaCelular)
                    .HasColumnName("com_cia_celular")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadLegal)
                    .HasColumnName("com_cia_ciudad_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadPostal)
                    .HasColumnName("com_cia_ciudad_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadela)
                    .HasColumnName("com_cia_ciudadela")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaEdificio)
                    .HasColumnName("com_cia_edificio")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaEstadoLegal)
                    .HasColumnName("com_cia_estado_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaFechaConstitucion)
                    .HasColumnName("com_cia_fecha_constitucion")
                    .HasColumnType("date");

                entity.Property(e => e.ComCiaFechaProrroga)
                    .HasColumnName("com_cia_fecha_prorroga")
                    .HasColumnType("date");

                entity.Property(e => e.ComCiaId)
                    .HasColumnName("com_cia_id")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaInterseccion)
                    .HasColumnName("com_cia_interseccion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaKilometro)
                    .HasColumnName("com_cia_kilometro")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaNombre)
                    .HasColumnName("com_cia_nombre")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaNumeroAcciones).HasColumnName("com_cia_numero_acciones");

                entity.Property(e => e.ComCiaNumeroCallePostal)
                    .HasColumnName("com_cia_numero_calle_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaObjetoSocial)
                    .HasColumnName("com_cia_objeto_social")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.ComCiaPaisOrigen)
                    .HasColumnName("com_cia_pais_origen")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaPisoDepartamento)
                    .HasColumnName("com_cia_piso_departamento")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaProvinciaLegal)
                    .HasColumnName("com_cia_provincia_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaProvinciaPostal)
                    .HasColumnName("com_cia_provincia_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaReferenciaUbicacion)
                    .HasColumnName("com_cia_referencia_ubicacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaSitioWeb)
                    .HasColumnName("com_cia_sitio_web")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTelefono)
                    .HasColumnName("com_cia_telefono")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTelefono2)
                    .HasColumnName("com_cia_telefono_2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTipoCompania)
                    .HasColumnName("com_cia_tipo_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaValorNominalAcciones)
                    .HasColumnName("com_cia_valor_nominal_acciones")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.ComCiaVencimientoPlazo)
                    .HasColumnName("com_cia_vencimiento_plazo")
                    .HasColumnType("date");

                entity.Property(e => e.ComIsActivo).HasColumnName("com_is_activo");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Supercias)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_sp_dp_com_datos_pr");
            });

            modelBuilder.Entity<Supercias1>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("supercias");

                entity.HasIndex(e => e.ComId)
                    .HasName("supercias_pk")
                    .IsUnique();

                entity.HasIndex(e => e.DpId)
                    .HasName("sp_dp_com_fk");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ComActEcoCiiu4)
                    .HasColumnName("com_act_eco_ciiu4")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComActEcoDescripcion)
                    .HasColumnName("com_act_eco_descripcion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaApartadoPostal).HasColumnName("com_cia_apartado_postal");

                entity.Property(e => e.ComCiaBarrio)
                    .HasColumnName("com_cia_barrio")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaBloque)
                    .HasColumnName("com_cia_bloque")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCallePostal)
                    .HasColumnName("com_cia_calle_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCamino)
                    .HasColumnName("com_cia_camino")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCantonLegal)
                    .HasColumnName("com_cia_canton_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCantonPostal)
                    .HasColumnName("com_cia_canton_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCapitalAutorizado)
                    .HasColumnName("com_cia_capital_autorizado")
                    .HasColumnType("money");

                entity.Property(e => e.ComCiaCapitalPagado)
                    .HasColumnName("com_cia_capital_pagado")
                    .HasColumnType("money");

                entity.Property(e => e.ComCiaCapitalSuscrito)
                    .HasColumnName("com_cia_capital_suscrito")
                    .HasColumnType("money");

                entity.Property(e => e.ComCiaCelular)
                    .HasColumnName("com_cia_celular")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadLegal)
                    .HasColumnName("com_cia_ciudad_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadPostal)
                    .HasColumnName("com_cia_ciudad_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaCiudadela)
                    .HasColumnName("com_cia_ciudadela")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaEdificio)
                    .HasColumnName("com_cia_edificio")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaEstadoLegal)
                    .HasColumnName("com_cia_estado_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaFechaConstitucion)
                    .HasColumnName("com_cia_fecha_constitucion")
                    .HasColumnType("date");

                entity.Property(e => e.ComCiaFechaProrroga)
                    .HasColumnName("com_cia_fecha_prorroga")
                    .HasColumnType("date");

                entity.Property(e => e.ComCiaId)
                    .HasColumnName("com_cia_id")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaInterseccion)
                    .HasColumnName("com_cia_interseccion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaKilometro)
                    .HasColumnName("com_cia_kilometro")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaNombre)
                    .HasColumnName("com_cia_nombre")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaNumeroAcciones).HasColumnName("com_cia_numero_acciones");

                entity.Property(e => e.ComCiaNumeroCallePostal)
                    .HasColumnName("com_cia_numero_calle_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaObjetoSocial)
                    .HasColumnName("com_cia_objeto_social")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.ComCiaPaisOrigen)
                    .HasColumnName("com_cia_pais_origen")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaPisoDepartamento)
                    .HasColumnName("com_cia_piso_departamento")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaProvinciaLegal)
                    .HasColumnName("com_cia_provincia_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaProvinciaPostal)
                    .HasColumnName("com_cia_provincia_postal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaReferenciaUbicacion)
                    .HasColumnName("com_cia_referencia_ubicacion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaSitioWeb)
                    .HasColumnName("com_cia_sitio_web")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTelefono)
                    .HasColumnName("com_cia_telefono")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTelefono2)
                    .HasColumnName("com_cia_telefono_2")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaTipoCompania)
                    .HasColumnName("com_cia_tipo_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComCiaValorNominalAcciones)
                    .HasColumnName("com_cia_valor_nominal_acciones")
                    .HasColumnType("money");

                entity.Property(e => e.ComCiaVencimientoPlazo)
                    .HasColumnName("com_cia_vencimiento_plazo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComIsActivo).HasColumnName("com_is_activo");

                entity.Property(e => e.DpId).HasColumnName("dp_id");

                entity.HasOne(d => d.Dp)
                    .WithMany(p => p.Supercias1)
                    .HasForeignKey(d => d.DpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_sp_dp_com_datos_pr");
            });

            modelBuilder.Entity<SuperciasAccionistas>(entity =>
            {
                entity.HasKey(e => e.ComAccionistaId);

                entity.ToTable("supercias_accionistas");

                entity.HasIndex(e => e.ComAccionistaId)
                    .HasName("supercias_accionistas_pk")
                    .IsUnique();

                entity.HasIndex(e => e.ComId)
                    .HasName("fk_com_acc_fk");

                entity.Property(e => e.ComAccionistaId).HasColumnName("com_accionista_id");

                entity.Property(e => e.ComAccionistaIsActivo).HasColumnName("com_accionista_is_activo");

                entity.Property(e => e.ComAccionistaNombreEmpresa)
                    .IsRequired()
                    .HasColumnName("com_accionista_nombre_empresa")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.ComAccionistaRucAccionista)
                    .HasColumnName("com_accionista_ruc_accionista")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.ComAccionistaTipoInversion)
                    .IsRequired()
                    .HasColumnName("com_accionista_tipo_inversion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAccionistaValorAccion)
                    .HasColumnName("com_accionista_valor_accion")
                    .HasColumnType("money");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SuperciasAccionistas)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_fk_com_ac_supercia");
            });

            modelBuilder.Entity<SuperciasAccionistas1>(entity =>
            {
                entity.HasKey(e => e.ComAccionistaId);

                entity.ToTable("supercias_accionistas", "interoperador");

                entity.HasIndex(e => e.ComAccionistaId)
                    .HasName("supercias_accionistas_pk")
                    .IsUnique();

                entity.HasIndex(e => e.ComId)
                    .HasName("fk_com_acc_fk");

                entity.Property(e => e.ComAccionistaId)
                    .HasColumnName("com_accionista_id")
                    .HasDefaultValueSql("nextval('interoperador.supercias_accionistas_com_accionista_id_seq'::regclass)");

                entity.Property(e => e.ComAccionistaIsActivo).HasColumnName("com_accionista_is_activo");

                entity.Property(e => e.ComAccionistaNombreEmpresa)
                    .HasColumnName("com_accionista_nombre_empresa")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.ComAccionistaRucAccionista)
                    .HasColumnName("com_accionista_ruc_accionista")
                    .HasColumnType("character varying(13)");

                entity.Property(e => e.ComAccionistaTipoInversion)
                    .HasColumnName("com_accionista_tipo_inversion")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAccionistaValorAccion)
                    .HasColumnName("com_accionista_valor_accion")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SuperciasAccionistas1)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_fk_com_ac_supercia");
            });

            modelBuilder.Entity<SuperciasAdministradores>(entity =>
            {
                entity.HasKey(e => e.ComAdminId);

                entity.ToTable("supercias_administradores", "interoperador");

                entity.HasIndex(e => e.ComAdminId)
                    .HasName("supercias_administradores_pk")
                    .IsUnique();

                entity.HasIndex(e => e.ComId)
                    .HasName("fk_com_adm_fk");

                entity.Property(e => e.ComAdminId)
                    .HasColumnName("com_admin_id")
                    .HasDefaultValueSql("nextval('interoperador.supercias_administradores_com_admin_id_seq'::regclass)");

                entity.Property(e => e.ComAdminCargo)
                    .HasColumnName("com_admin_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminCedulaAdministrador)
                    .HasColumnName("com_admin_cedula_administrador")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminCodigoCargo)
                    .HasColumnName("com_admin_codigo_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminFechaInscRegMer)
                    .HasColumnName("com_admin_fecha_insc_reg_mer")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminFechaNombramiento)
                    .HasColumnName("com_admin_fecha_nombramiento")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminFechaVencimiento)
                    .HasColumnName("com_admin_fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminIsActivo).HasColumnName("com_admin_is_activo");

                entity.Property(e => e.ComAdminNombreAdministrador)
                    .HasColumnName("com_admin_nombre_administrador")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminNombreCompania)
                    .HasColumnName("com_admin_nombre_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminNumRegistroRegMer)
                    .HasColumnName("com_admin_num_registro_reg_mer")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminPeriodo)
                    .HasColumnName("com_admin_periodo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminRepresentanteLegal)
                    .HasColumnName("com_admin_representante_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminRuc)
                    .HasColumnName("com_admin_ruc")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SuperciasAdministradores)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_fk_com_ad_supercia");
            });

            modelBuilder.Entity<SuperciasAdministradores1>(entity =>
            {
                entity.HasKey(e => e.ComAdminId);

                entity.ToTable("supercias_administradores");

                entity.HasIndex(e => e.ComAdminId)
                    .HasName("supercias_administradores_pk")
                    .IsUnique();

                entity.HasIndex(e => e.ComId)
                    .HasName("fk_com_adm_fk");

                entity.Property(e => e.ComAdminId).HasColumnName("com_admin_id");

                entity.Property(e => e.ComAdminCargo)
                    .HasColumnName("com_admin_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminCedulaAdministrador)
                    .HasColumnName("com_admin_cedula_administrador")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminCodigoCargo)
                    .HasColumnName("com_admin_codigo_cargo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminFechaInscRegMer)
                    .HasColumnName("com_admin_fecha_insc_reg_mer")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminFechaNombramiento)
                    .HasColumnName("com_admin_fecha_nombramiento")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminFechaVencimiento)
                    .HasColumnName("com_admin_fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.ComAdminIsActivo).HasColumnName("com_admin_is_activo");

                entity.Property(e => e.ComAdminNombreAdministrador)
                    .HasColumnName("com_admin_nombre_administrador")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminNombreCompania)
                    .HasColumnName("com_admin_nombre_compania")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminNumRegistroRegMer)
                    .HasColumnName("com_admin_num_registro_reg_mer")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminPeriodo)
                    .HasColumnName("com_admin_periodo")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminRepresentanteLegal)
                    .HasColumnName("com_admin_representante_legal")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComAdminRuc)
                    .HasColumnName("com_admin_ruc")
                    .HasColumnType("character varying(50)");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SuperciasAdministradores1)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supercia_fk_com_ad_supercia");
            });

            modelBuilder.Entity<Unidadadministrativa>(entity =>
            {
                entity.HasKey(e => e.IdUnidadAdministrativa);

                entity.ToTable("unidadadministrativa", "comun");

                entity.HasIndex(e => e.IdPadre)
                    .HasName("uniadm_uniadm_fk");

                entity.HasIndex(e => e.IdUnidadAdministrativa)
                    .HasName("unidadadministrativa_pk")
                    .IsUnique();

                entity.Property(e => e.IdUnidadAdministrativa)
                    .HasColumnName("id_unidad_administrativa")
                    .HasDefaultValueSql("nextval('comun.unidadadministrativa_id_unidad_administrativa_seq'::regclass)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdCiudad).HasColumnName("id_ciudad");

                entity.Property(e => e.IdContinente).HasColumnName("id_continente");

                entity.Property(e => e.IdPadre).HasColumnName("id_padre");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");

                entity.Property(e => e.IdRegion).HasColumnName("id_region");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Siglas)
                    .IsRequired()
                    .HasColumnName("siglas")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("character varying(20)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdPadreNavigation)
                    .WithMany(p => p.InverseIdPadreNavigation)
                    .HasForeignKey(d => d.IdPadre)
                    .HasConstraintName("fk_unidadad_unidadadm_unidadad");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("usuario", "seguridad");

                entity.HasIndex(e => e.IdUnidadAdministrativa)
                    .HasName("unidadadministrativa_usuario_fk");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("usuario_pk")
                    .IsUnique();

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasDefaultValueSql("nextval('seguridad.usuario_id_usuario_seq'::regclass)");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasColumnName("cuenta")
                    .HasColumnType("character varying(30)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCaducidad).HasColumnName("fecha_caducidad");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IdUnidadAdministrativa).HasColumnName("id_unidad_administrativa");

                entity.Property(e => e.Intentos).HasColumnName("intentos");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.IsInterno)
                    .HasColumnName("is_interno")
                    .ForNpgsqlHasComment("Si campo es true el usuario es interno, caso contrario es externo");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying(256)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdUnidadAdministrativaNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdUnidadAdministrativa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_unidadadm_unidadad");
            });

            modelBuilder.Entity<UsuarioGupo>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuarioGrupo, e.IdUsuario, e.IdGrupo });

                entity.ToTable("usuario_gupo", "seguridad");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("usuario_gupo2_fk");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("usuario_gupo_fk");

                entity.HasIndex(e => new { e.IdUsuarioGrupo, e.IdUsuario, e.IdGrupo })
                    .HasName("usuario_gupo_pk")
                    .IsUnique();

                entity.Property(e => e.IdUsuarioGrupo)
                    .HasColumnName("id_usuario_grupo")
                    .HasDefaultValueSql("nextval('seguridad.usuario_gupo_id_usuario_grupo_seq'::regclass)");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.UsuarioGupo)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_g_grupo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioGupo)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_g_usuario");
            });

            modelBuilder.Entity<UsuarioRol>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuarioRol, e.IdRol, e.IdUsuario });

                entity.ToTable("usuario_rol", "seguridad");

                entity.HasIndex(e => e.IdRol)
                    .HasName("usuario_rol_fk");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("usuario_rol2_fk");

                entity.HasIndex(e => new { e.IdUsuarioRol, e.IdRol, e.IdUsuario })
                    .HasName("usuario_rol_pk")
                    .IsUnique();

                entity.Property(e => e.IdUsuarioRol)
                    .HasColumnName("id_usuario_rol")
                    .HasDefaultValueSql("nextval('seguridad.usuario_rol_id_usuario_rol_seq'::regclass)");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_r_rol");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_r_usuario");
            });

            modelBuilder.Entity<UsuarioSistema>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuarioSistema, e.IdUsuario, e.IdSistema });

                entity.ToTable("usuario_sistema", "seguridad");

                entity.HasIndex(e => e.IdSistema)
                    .HasName("usuario_sistema2_fk");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("usuario_sistema_fk");

                entity.HasIndex(e => new { e.IdUsuarioSistema, e.IdUsuario, e.IdSistema })
                    .HasName("usuario_sistema_pk")
                    .IsUnique();

                entity.Property(e => e.IdUsuarioSistema)
                    .HasColumnName("id_usuario_sistema")
                    .HasDefaultValueSql("nextval('seguridad.usuario_sistema_id_usuario_sistema_seq'::regclass)");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.IdSistema).HasColumnName("id_sistema");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.IsActivo).HasColumnName("is_activo");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");

                entity.HasOne(d => d.IdSistemaNavigation)
                    .WithMany(p => p.UsuarioSistema)
                    .HasForeignKey(d => d.IdSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_s_sistema");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioSistema)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario__usuario_s_usuario");
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.HasKey(e => e.IdZona);

                entity.ToTable("zona", "comun");

                entity.Property(e => e.IdZona)
                    .HasColumnName("id_zona")
                    .HasDefaultValueSql("nextval('comun.zona_id_zona_seq'::regclass)");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("character varying(100)");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.HasSequence("lineamiento_pnbv_id_lineamiento_pnbv_seq");

            modelBuilder.HasSequence("macrosector_senplades_id_macrosector_senplades_seq");

            modelBuilder.HasSequence("meta_pnbv_id_meta_pnbv_seq");

            modelBuilder.HasSequence("objetivo_pnbv_id_objetivo_pnbv_seq");

            modelBuilder.HasSequence("periodo_pnbv_id_periodo_pnbv_seq");

            modelBuilder.HasSequence("politica_pnbv_id_politica_pnbv_seq");

            modelBuilder.HasSequence("sector_senplades_id_sector_senplades_seq");

            modelBuilder.HasSequence("subsector_senplades_id_subsector_senplades_seq");

            modelBuilder.HasSequence("canton_id_canton_seq");

            modelBuilder.HasSequence("catalogo_detalle_id_catalogo_detalle_seq");

            modelBuilder.HasSequence("catalogo_id_catalogo_seq");

            modelBuilder.HasSequence("circuito_id_circuito_seq");

            modelBuilder.HasSequence("continente_id_continente_seq");

            modelBuilder.HasSequence("distrito_id_distrito_seq");

            modelBuilder.HasSequence("entidad_id_entidad_seq");

            modelBuilder.HasSequence("moneda_id_moneda_seq");

            modelBuilder.HasSequence("pais_id_pais_seq");

            modelBuilder.HasSequence("parroquia_id_parroquia_seq");

            modelBuilder.HasSequence("provincia_id_provincia_seq");

            modelBuilder.HasSequence("region_id_region_seq");

            modelBuilder.HasSequence("unidadadministrativa_id_unidad_administrativa_seq");

            modelBuilder.HasSequence("zona_id_zona_seq");

            modelBuilder.HasSequence("ant_ant_vehiculo_id_seq");

            modelBuilder.HasSequence("datos_principales_dp_id_seq");

            modelBuilder.HasSequence("jnda_jnd_id_seq");

            modelBuilder.HasSequence("ministerio_educacion_edu_id_seq");

            modelBuilder.HasSequence("poc_datos_personales_id_seq");

            modelBuilder.HasSequence("registro_civil_rc_id_seq");

            modelBuilder.HasSequence("registro_propiedad_rp_id_seq");

            modelBuilder.HasSequence("rm_contratos_rmc_id_seq");

            modelBuilder.HasSequence("rm_societarios_rm_act_soc_id_seq");

            modelBuilder.HasSequence("secap_cursos_sec_id_seq");

            modelBuilder.HasSequence("senescyt_snc_id_seq");

            modelBuilder.HasSequence("seps_sep_id_seq");

            modelBuilder.HasSequence("sri_establecimientos_sri_est_id_seq");

            modelBuilder.HasSequence("sri_estados_tributarios_sri_est_tributario_id_seq");

            modelBuilder.HasSequence("sri_sri_ruc_id_seq");

            modelBuilder.HasSequence("supercias_accionistas_com_accionista_id_seq");

            modelBuilder.HasSequence("supercias_administradores_com_admin_id_seq");

            modelBuilder.HasSequence("supercias_com_id_seq");

            modelBuilder.HasSequence("programa_id_programa_seq");

            modelBuilder.HasSequence("proyecto_beneficiario_id_proyecto_beneficiario_seq");

            modelBuilder.HasSequence("proyecto_contraparte_id_proyecto_contraparte_seq");

            modelBuilder.HasSequence("proyecto_cooperante_id_proyecto_cooperante_seq");

            modelBuilder.HasSequence("proyecto_desembolso_id_proyecto_desembolso_seq");

            modelBuilder.HasSequence("proyecto_entidad_id_proyecto_entidad_seq");

            modelBuilder.HasSequence("proyecto_id_proyecto_seq");

            modelBuilder.HasSequence("proyecto_modalidad_cooperacio_id_proyecto_modalidad_coopera_seq");

            modelBuilder.HasSequence("proyecto_observacion_id_proyecto_observacion_seq");

            modelBuilder.HasSequence("proyecto_otra_aportacion_id_proyecto_otra_aportacion_seq");

            modelBuilder.HasSequence("proyecto_pdot_id_proyecto_pdot_seq");

            modelBuilder.HasSequence("proyecto_pnbv_id_proyecto_pnbv_seq");

            modelBuilder.HasSequence("proyecto_sector_id_proyecto_sector_seq");

            modelBuilder.HasSequence("proyecto_ubicacion_id_proyecto_ubicacion_seq");

            modelBuilder.HasSequence("acceso_id_acceso_seq");

            modelBuilder.HasSequence("detalleusuario_id_detalle_usuario_seq");

            modelBuilder.HasSequence("funcionalidad_gruporol_id_funcionalidad_gruporol_seq");

            modelBuilder.HasSequence("funcionalidad_id_funcionalidad_seq");

            modelBuilder.HasSequence("funcionalidad_rol_id_funcionalidad_rol_seq");

            modelBuilder.HasSequence("grupo_id_grupo_seq");

            modelBuilder.HasSequence("gruporol_id_grupo_rol_seq");

            modelBuilder.HasSequence("rol_id_rol_seq");

            modelBuilder.HasSequence("sistema_id_sistema_seq");

            modelBuilder.HasSequence("usuario_gupo_id_usuario_grupo_seq");

            modelBuilder.HasSequence("usuario_id_usuario_seq");

            modelBuilder.HasSequence("usuario_rol_id_usuario_rol_seq");

            modelBuilder.HasSequence("usuario_sistema_id_usuario_sistema_seq");
        }
    }
}
