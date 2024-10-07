using REPASO2.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO2.provedores
{
    public class Transporte : IProcesadorEnvios
    {
        double distanciaKm;
        double precioPorKm;
        public Transporte(int Distanciakm, double PrecioporKM)
        {

            distanciaKm = Distanciakm;
            precioPorKm = PrecioporKM;

        }

        public void ProcesadorEnvios(IProcesable[] envios)
        {
            if (envios != null && envios.Length > 0)
            {
                double valorPorProducto = distanciaKm * precioPorKm / envios.Length;

                foreach (IProcesable p in envios)
                {
                    p.CrearCosto("Costo de transporte por unidad", valorPorProducto);
                }
            }

        }
    }

     }
