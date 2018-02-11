namespace WebPruebaData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using WebPruebaData.Entities;
    using System.Linq;

    public partial class PedidoCliente
    {
        private tblPedidosCliente Pedido;
        public PedidoCliente(tblPedidosCliente pedido)
        {
            Pedido = pedido;

            Usuario = Pedido.tblUsuario.NombreCompletoUsuario;

            Caja = Pedido.tblCaja.DesCaja;

            Cliente = Pedido.tblCliente.NombreCliente;

            FormaComunicacion = Pedido.tblFormaComunicacion.desFormaComunicacion;

            FechaPedido = Pedido.FechaPedido;

            Equipo = Pedido.Equipo;

            Descripcion = Pedido.Descripcion;

            PrecioInformado = Pedido.PrecioInformado;

            EstadoPedido = Pedido.tblEstadosPedido.desEstadoPedido;

            FechaEstado = Pedido.FechaEstado;

            DescripcionSolucion = Pedido.DescripcionSolucion;

            PrecioCobrado = Pedido.tblSalidasCab.tblSalidasDets.Sum(s => s.PrecioVenta * s.Cantidad);
        }

        public string Usuario { get; set; }

        public string Caja { get; set; }

        public string Cliente { get; set; }

        public string FormaComunicacion { get; set; }

        public DateTime? FechaPedido { get; set; }

        public string Equipo { get; set; }

        public string Descripcion { get; set; }

        public decimal? PrecioInformado { get; set; }

        public string EstadoPedido { get; set; }

        public DateTime? FechaEstado { get; set; }

        public string DescripcionSolucion { get; set; }

        public decimal? PrecioCobrado { get; set; }

        //public PedidoCliente GetPedidoCliente()
        //{
        //    Usuario = Pedido.tblUsuario.NombreCompletoUsuario;

        //    Caja = Pedido.tblCaja.DesCaja;

        //    Cliente = Pedido.tblCliente.NombreCliente;

        //    FormaComunicacion = Pedido.tblFormaComunicacion.desFormaComunicacion;

        //    FechaPedido = Pedido.FechaPedido;

        //    Equipo = Pedido.Equipo;

        //    Descripcion = Pedido.Descripcion;

        //    PrecioInformado = Pedido.PrecioInformado;

        //    EstadoPedido = Pedido.tblEstadosPedido.desEstadoPedido;

        //    FechaEstado = Pedido.FechaEstado;

        //    DescripcionSolucion = Pedido.DescripcionSolucion;


        //}
    }
}
