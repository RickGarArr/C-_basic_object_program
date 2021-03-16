using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class Teclado : DispositivoEntrada
    {
        private static int contador;
        private int idTeclado { get; }

        public Teclado() { }
        public Teclado (string tipoEntrada, string marca) : base(tipoEntrada, marca)
        {
            idTeclado = ++contador;
        }

        public int getTotalTeclados()
        {
            return contador;
        }

        public override string ToString()
        {
            return string.Format("idTeclado: {0} ", idTeclado + base.ToString());
        }
    }
}
