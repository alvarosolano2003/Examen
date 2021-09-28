using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class AtivoModel
    {
        private ActivoFijo[] activos;
        
        // Agregar
        public void Add(ActivoFijo e)
        {
            if (activos == null)
            {
                activos[0] = e;
            }

            ActivoFijo[] tmp = new ActivoFijo[activos.Length + 1];
            Array.Copy(activos, tmp, activos.Length);
            activos = tmp;
        }

        public decimal[] DepreciacionEnLineaRecta(ActivoFijo e)
        {
            decimal[] depreciacionTotal = new decimal[e.VidaUtil];
            decimal mlr = (e.ValorActivo - e.ValorResidual) / e.VidaUtil;
            decimal depreciacionAnual = e.ValorActivo * mlr;
            decimal aux = e.ValorActivo;

            for (int i = 0; i < depreciacionTotal.Length; i++)
            {
                aux = aux - depreciacionAnual;
                depreciacionTotal[i] = aux;
            }

            return depreciacionTotal;
        }

        public decimal[] SDADepreciacion(ActivoFijo e)
        {
            decimal[] depreciacionTotal = new decimal[e.VidaUtil];
            int indice = e.VidaUtil, aux = e.VidaUtil;

            for (int i = 0; i < depreciacionTotal.Length; i++)
            {
                indice = indice + (indice - 1);
            }

            for (int i = 0; i < depreciacionTotal.Length; i++)
            {
                depreciacionTotal[i] = (aux / indice) * (e.ValorActivo - e.ValorResidual);
                aux--;
            }

            return depreciacionTotal;
        }
    }
}
