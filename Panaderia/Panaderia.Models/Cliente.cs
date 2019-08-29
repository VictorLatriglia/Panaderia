using System;
using System.Collections.Generic;
using System.Text;

namespace Panaderia.Models
{
    public class Cliente : EntityBase<int>
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeVinculacion { get; set; }
    }
}
