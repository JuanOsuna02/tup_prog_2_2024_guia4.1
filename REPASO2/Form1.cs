using REPASO2.API;
using REPASO2.CLIENTES;
using REPASO2.provedores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            #region casos de prueba
            Envio[] envios = new Envio[] //lista de envíos planificados
            {
    new Envio(2423),
    new Envio(2323),
    new Envio(2293),
    new Envio(1423)
            };

            ArrayList agentesCargos = new ArrayList() //agentes de recargos
  {
    new Transporte(2344,23),
    new Aduana(23244),
  };
            #endregion

            #region proceso de los envíos
            foreach (IProcesadorEnvios agente in agentesCargos)
            {
                agente.ProcesadorEnvios(envios);
            }
            #endregion


            #region impresión de la lista de envíos
            Ordenar(envios, envios.Length);//por lo del length, se que el vector está completo!
            foreach (IProcesable env in envios)
            {
                textBox1.Text += $"{env.ToString()}\r\n";//número aduanero

                for (int idx = 0; idx < env.CantEnvios; idx++)
                {
                    textBox1.Text += env.VerCosto(idx).ToString() + "\r\n";//concepto y valor
                }

                textBox1.Text += $"Total:{env.CostoTot:f2}\r\n\r\n";//total
            }
            #endregion
        }




        private void Ordenar(IComparable[] envios, int cantidad)
        {
            for (int n = 0; n < cantidad - 1; n++)
            {
                for (int m = n + 1; m < cantidad; m++)
                {
                    if (envios[n].CompareTo(envios[m]) > 0)
                    {
                        IComparable aux = envios[m];
                        envios[m] = envios[n];
                        envios[n] = aux;
                    }
                }
            }
        }


    }
}
