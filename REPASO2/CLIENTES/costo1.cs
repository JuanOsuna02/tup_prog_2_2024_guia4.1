using REPASO2.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.CLIENTES
{
    public class costo1 : ICosto
    {
        public string Concepto { get;  }
        public double Valor { get;  }

        public costo1(string CONCEPTO,double VALOR) {

            Concepto=CONCEPTO;
            Valor = VALOR;
        }
        public override string ToString()
        {
            return $"{Concepto,-35}{Valor,10:f2}";
        }
    }
}
