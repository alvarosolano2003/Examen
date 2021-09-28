using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivoFijo TipoActivoFijo { get; set; }
        public MetodoDepreciacion MetodoDepreciacion { get; set; }
    }
}
