using System;
using System.Collections.Generic;
using System.Text;

namespace Panaderia.Models
{
    public class ProductoVendido : EntityBase<int>
    {
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public DateTime FechaDeVenta { get; set; }
        public int CantidadVendida { get; set; }
    }
}
