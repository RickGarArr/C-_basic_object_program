using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class Computadora
    {
        private static int contador;
        private int idComputadora { get; }
        private Mouse mouse { set; get; }
        private Teclado teclado { set; get; }
        private Monitor monitor { set; get; }

        public Computadora() { }

        public Computadora(Mouse mouse, Teclado teclado, Monitor monitor)
        {
            idComputadora = ++contador;
            this.mouse = mouse;
            this.teclado = teclado;
            this.monitor = monitor;
        }

        public int getTotalComputadoras()
        {
            return contador;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("idComputadora: ").Append(idComputadora).Append("\n");
            sb.Append("Monitor: ").Append(monitor.ToString()).Append("\n");
            sb.Append("Teclado: ").Append(teclado.ToString()).Append("\n");
            sb.Append("Mouse: ").Append(mouse.ToString()).Append("\n");
            sb.Append("\n");
            return sb.ToString();
        }
    }
}
