namespace WebPruebaData.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataConectionString")
        {
        }

        public virtual DbSet<tblArea> tblAreas { get; set; }
        public virtual DbSet<tblBanco> tblBancos { get; set; }
        public virtual DbSet<tblCaja> tblCajas { get; set; }
        public virtual DbSet<tblCausa> tblCausas { get; set; }
        public virtual DbSet<tblCliente> tblClientes { get; set; }
        public virtual DbSet<tblColumnasLibroGasto> tblColumnasLibroGastos { get; set; }
        public virtual DbSet<tblConcepto> tblConceptos { get; set; }
        public virtual DbSet<tblCuenta> tblCuentas { get; set; }
        public virtual DbSet<tblDetalle> tblDetalles { get; set; }
        public virtual DbSet<tblDetallesGrupos> tblDetallesGrupos { get; set; }
        public virtual DbSet<tblDetallesProducto> tblDetallesProductos { get; set; }
        public virtual DbSet<tblDireccionesCliente> tblDireccionesClientes { get; set; }
        public virtual DbSet<tblDondeNosConocio> tblDondeNosConocios { get; set; }
        public virtual DbSet<tblEmpresa> tblEmpresas { get; set; }
        public virtual DbSet<tblEntradasCab> tblEntradasCabs { get; set; }
        public virtual DbSet<tblEntradasDet> tblEntradasDets { get; set; }
        public virtual DbSet<tblEntregasCuenta> tblEntregasCuentas { get; set; }
        public virtual DbSet<tblEstadosPedido> tblEstadosPedidos { get; set; }
        public virtual DbSet<tblFormaComunicacion> tblFormaComunicacions { get; set; }
        public virtual DbSet<tblFormasPago> tblFormasPagoes { get; set; }
        public virtual DbSet<tblGrupos> tblGrupos { get; set; }
        public virtual DbSet<tblPedidosCliente> tblPedidosClientes { get; set; }
        public virtual DbSet<tblPoblacione> tblPoblaciones { get; set; }
        public virtual DbSet<tblProducto> tblProductos { get; set; }
        public virtual DbSet<tblProveedore> tblProveedores { get; set; }
        public virtual DbSet<tblProvincia> tblProvincias { get; set; }
        public virtual DbSet<tblSalidasCab> tblSalidasCabs { get; set; }
        public virtual DbSet<tblSalidasDet> tblSalidasDets { get; set; }
        public virtual DbSet<tblSeriesFactura> tblSeriesFacturas { get; set; }
        public virtual DbSet<tblStock> tblStocks { get; set; }
        public virtual DbSet<tblSubgrupos> tblSubgrupos { get; set; }
        public virtual DbSet<tblTiposGrupos> tblTiposGrupos { get; set; }
        public virtual DbSet<tblUmedida> tblUmedidas { get; set; }
        public virtual DbSet<tblUsuario> tblUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblArea>()
                .Property(e => e.desArea)
                .IsUnicode(false);

            modelBuilder.Entity<tblBanco>()
                .Property(e => e.DesBanco)
                .IsUnicode(false);

            modelBuilder.Entity<tblBanco>()
                .HasMany(e => e.tblCuentas)
                .WithRequired(e => e.tblBanco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.NumCaja)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.DesCaja)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraTickets)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraEtiquetas)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraFacturas)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraReportes)
                .IsUnicode(false);

            modelBuilder.Entity<tblCausa>()
                .Property(e => e.DesCausa)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.TelCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.ObsCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblColumnasLibroGasto>()
                .Property(e => e.NombreColumna)
                .IsUnicode(false);

            modelBuilder.Entity<tblConcepto>()
                .Property(e => e.DesConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<tblCuenta>()
                .Property(e => e.DesCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tblCuenta>()
                .Property(e => e.NumCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tblDetalle>()
                .Property(e => e.desDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDetallesProducto>()
                .Property(e => e.valorDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.AliasDirCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.NomDirCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.NIF)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.FijoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.MovilCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblDireccionesCliente>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<tblDondeNosConocio>()
                .Property(e => e.DesDonde)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.NIFEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.NomComercial)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DesEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.TelEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.CelEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.FaxEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.EmailEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.WebEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirImagEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirCopiaTickets)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradasCab>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradasCab>()
                .Property(e => e.CopiaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradasCab>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradasCab>()
                .HasMany(e => e.tblEntradasDets)
                .WithOptional(e => e.tblEntradasCab)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.PrecioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.IVAProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.IRPF)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.DescuetoProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblEntradasDet>()
                .Property(e => e.ObservDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntregasCuenta>()
                .Property(e => e.ObservEntregaCta)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntregasCuenta>()
                .Property(e => e.ImporteEntregado)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblEstadosPedido>()
                .Property(e => e.desEstadoPedido)
                .IsUnicode(false);

            modelBuilder.Entity<tblEstadosPedido>()
                .HasMany(e => e.tblPedidosClientes)
                .WithOptional(e => e.tblEstadosPedido)
                .HasForeignKey(e => e.idEstadoPedido);

            modelBuilder.Entity<tblEstadosPedido>()
                .HasMany(e => e.tblPedidosClientes1)
                .WithOptional(e => e.tblEstadosPedido1)
                .HasForeignKey(e => e.idEstadoPedidoAnterior);

            modelBuilder.Entity<tblFormaComunicacion>()
                .Property(e => e.desFormaComunicacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormasPago>()
                .Property(e => e.DesFormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<tblGrupos>()
                .Property(e => e.desGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblGrupos>()
                .Property(e => e.IVAGrupo)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblGrupos>()
                .Property(e => e.Margen)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblGrupos>()
                .HasMany(e => e.tblDetallesGrupos)
                .WithOptional(e => e.tblGrupos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblGrupos>()
                .HasMany(e => e.tblProductos)
                .WithRequired(e => e.tblGrupos)
                .HasForeignKey(e => e.idGrupo1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblGrupos>()
                .HasMany(e => e.tblProductos1)
                .WithOptional(e => e.tblGrupos1)
                .HasForeignKey(e => e.idGrupo2);

            modelBuilder.Entity<tblGrupos>()
                .HasMany(e => e.tblProductos2)
                .WithOptional(e => e.tblGrupos2)
                .HasForeignKey(e => e.idGrupo3);

            modelBuilder.Entity<tblGrupos>()
                .HasMany(e => e.tblSubgrupos)
                .WithOptional(e => e.tblGrupos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblPedidosCliente>()
                .Property(e => e.Equipo)
                .IsUnicode(false);

            modelBuilder.Entity<tblPedidosCliente>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tblPedidosCliente>()
                .Property(e => e.PrecioInformado)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblPedidosCliente>()
                .Property(e => e.DescripcionSolucion)
                .IsUnicode(false);

            modelBuilder.Entity<tblPoblacione>()
                .Property(e => e.poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblPoblacione>()
                .Property(e => e.postal)
                .IsUnicode(false);

            modelBuilder.Entity<tblPoblacione>()
                .HasMany(e => e.tblProveedores)
                .WithOptional(e => e.tblPoblacione)
                .HasForeignKey(e => e.IdPoblacion);

            modelBuilder.Entity<tblPoblacione>()
                .HasMany(e => e.tblProveedores1)
                .WithOptional(e => e.tblPoblacione1)
                .HasForeignKey(e => e.IdPobFiscal);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.eanProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.desProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.desProductoCorta)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.precioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.precioVenta)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.X)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Z)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.StockMin)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.StockMax)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.FotoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.ObservProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Inventario)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .HasMany(e => e.tblDetallesProductos)
                .WithOptional(e => e.tblProducto)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblProveedore>()
                .Property(e => e.DesProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedore>()
                .Property(e => e.DirProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedore>()
                .Property(e => e.DirFiscalProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedore>()
                .Property(e => e.WebProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProvincia>()
                .Property(e => e.provincia)
                .IsUnicode(false);

            modelBuilder.Entity<tblProvincia>()
                .Property(e => e.provincia3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.CopiaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.ObservInterna)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.DescuentoPorciento)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.DescuentoValor)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidasCab>()
                .Property(e => e.ImporteRecibido)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidasCab>()
                .HasMany(e => e.tblSalidasDets)
                .WithOptional(e => e.tblSalidasCab)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.ObservDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.PrecioVenta)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.PrecioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.IVAProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSalidasDet>()
                .Property(e => e.DescuentoProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSeriesFactura>()
                .Property(e => e.NomSerieFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSeriesFactura>()
                .Property(e => e.DescSerieFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSeriesFactura>()
                .HasOptional(e => e.tblSeriesFacturas1)
                .WithRequired(e => e.tblSeriesFactura1);

            modelBuilder.Entity<tblStock>()
                .Property(e => e.Stock)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblStock>()
                .Property(e => e.PrecioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblSubgrupos>()
                .Property(e => e.desSubgrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblSubgrupos>()
                .Property(e => e.Margen)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSubgrupos>()
                .HasMany(e => e.tblProductos)
                .WithRequired(e => e.tblSubgrupos)
                .HasForeignKey(e => e.idSubgrupo1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSubgrupos>()
                .HasMany(e => e.tblProductos1)
                .WithOptional(e => e.tblSubgrupos1)
                .HasForeignKey(e => e.idSubgrupo2);

            modelBuilder.Entity<tblSubgrupos>()
                .HasMany(e => e.tblProductos2)
                .WithOptional(e => e.tblSubgrupos2)
                .HasForeignKey(e => e.idSubgrupo3);

            modelBuilder.Entity<tblTiposGrupos>()
                .Property(e => e.DesTipoGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblTiposGrupos>()
                .HasMany(e => e.tblGrupos)
                .WithOptional(e => e.tblTiposGrupos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblTiposGrupos>()
                .HasMany(e => e.tblProductos)
                .WithOptional(e => e.tblTiposGrupos)
                .HasForeignKey(e => e.idTipoGrupo1);

            modelBuilder.Entity<tblUmedida>()
                .Property(e => e.codUmedida)
                .IsUnicode(false);

            modelBuilder.Entity<tblUmedida>()
                .Property(e => e.desUmedida)
                .IsUnicode(false);

            modelBuilder.Entity<tblUmedida>()
                .HasMany(e => e.tblProductos)
                .WithRequired(e => e.tblUmedida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.NombreCompletoUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.ClaveUsuario)
                .IsUnicode(false);
        }
    }
}
