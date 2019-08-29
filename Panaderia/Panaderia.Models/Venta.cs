using System;
using System.Collections.Generic;
using System.Text;

namespace Panaderia.Models
{
    public class Venta : EntityBase<int>
    {
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public double MontoTotal { get; set; }
    }
}
