using Dominio;
using Dominio.Enums;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmActivoFijo : Form
    {
        public int count { get; set; }
        public AtivoModel objActivo;
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string id, nombre, descripcion;
            decimal valorAc, valorAdquisicion;
            DateTime fechaAdquisicion;

            id = txtID.Text;
            nombre = txtNombre.Text;
            descripcion = txtDescripcion.Text;
            valorAc = nudValorActivo.Value;
            valorAdquisicion = nudValorResidual.Value;
            fechaAdquisicion = DateTime.Parse(dptAdquisicion.Text);

            ActivoFijo act = new ActivoFijo()
            {
                Id = ++count,
                CodigoActivo = id,
                NombreActivo = nombre,
                ValorActivo = valorAc,
                ValorResidual = valorAdquisicion,
                FechaAdquisicion = fechaAdquisicion,
                //TipoActivoFijo = int.Parse(cmbTipoActivo),
                //MetodoDepreciacion = MetodoDepreciacion
            };

            objActivo.Add(act);
        }
    }
}
