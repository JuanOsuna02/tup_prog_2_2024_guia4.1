using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.API
{
    public interface IProcesadorEnvios
    {
         void ProcesadorEnvios(IProcesable[] procesables);
    }
}
