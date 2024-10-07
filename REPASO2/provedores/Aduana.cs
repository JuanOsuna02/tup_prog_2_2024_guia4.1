using REPASO2.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.provedores
{
    public class Aduana:IProcesadorEnvios
    {
        double ValorFijo;
        public Aduana(double valorFijo)
        {
            ValorFijo = valorFijo;
        }

        public void ProcesadorEnvios(IProcesable[]envios) {
            double valorPorProducto = ValorFijo;

            if (envios != null)
                foreach (IProcesable p in envios)
                {
                    p.CrearCosto("Costo aduanero", valorPorProducto);
                }
        }
    }
}
