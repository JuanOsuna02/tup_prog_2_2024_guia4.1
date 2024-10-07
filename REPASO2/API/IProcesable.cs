using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.API
{
    public interface IProcesable
    {
          int CantEnvios { get; }
        double CostoTot {  get; }
          ICosto CrearCosto(string Concepto, double Valor);
        ICosto VerCosto(int idx);

    }
}
