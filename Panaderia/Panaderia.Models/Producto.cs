using System;
using System.Collections.Generic;
using System.Text;

namespace Panaderia.Models
{
    public class Producto : EntityBase<int>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ImageUrl { get; set; }
        public double PrecioUnitario { get; set; }
        public int CantidadActual { get; set; }
    }
}
