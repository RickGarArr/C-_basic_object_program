using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class Monitor
    {
        private static int contador;
        private int idMonitor { get; }
        private string marca { set; get; }
        private double pulgadas { set; get; }

        public Monitor() { }

        public Monitor(string marca, double pulgadas)
        {
            idMonitor = ++contador;
            this.marca = marca;
            this.pulgadas = pulgadas;
        }

        public int getTotalMonitores()
        {
            return contador;
        }

        public override string ToString()
        {
            return string.Format("idMonitor: {0}, marca: {1}, pulgadas: {2}", idMonitor, marca, pulgadas); 
        }
    }
}
