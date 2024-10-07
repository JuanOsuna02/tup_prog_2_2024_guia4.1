using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.API
{
    public interface ICosto
    {
        string Concepto { get; }
        double Valor { get; }
    }
}
