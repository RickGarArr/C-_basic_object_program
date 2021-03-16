using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class Mouse : DispositivoEntrada
    {
        private static int contador;
        private int idMouse { get; }

        public Mouse() { }
        public Mouse(string tipoEntrada, string marca) : base(tipoEntrada, marca)
        {
            idMouse = ++contador;
        }

        public int getTotalMouses()
        {
            return contador;
        }

        public override string ToString()
        {
            return string.Format("idMouse: {0} ", idMouse + base.ToString());
        }
    }
}
