using REPASO2.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.CLIENTES
{
    public class Envio:IComparable,IProcesable

    {
        public int NumeroAduanero { get; private set; }
        public double CostoTot
        {
            get
            {
                double total = 0;
                foreach (ICosto c in costos)
                {
                    total += c.Valor;
                }
                return total;
            }
        }
        public int CantEnvios
        {
            get
            {
                if (costos != null)
                    return costos.Count;
                else return 0;
            }
        }

        public ArrayList costos = new ArrayList();


        public Envio(int numeroAduanero)
        {
            this.NumeroAduanero = numeroAduanero;
        }
        public override string ToString()
        {
            return $"Envío: {NumeroAduanero,10:000000}";
        }
        public ICosto VerCosto (int idx)
        {
            if (idx >= 0 && idx < CantEnvios)
                return costos[idx] as ICosto;
            return null;

        }

        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;
            if (envio != null)
            {
                return NumeroAduanero.CompareTo(envio.NumeroAduanero);
            }
            return -1;
        }

        public ICosto CrearCosto(string concepto, double valor)
        {
            ICosto c = new costo1(concepto, valor);
            costos.Add(c);
            return c;
        }

    }
}
