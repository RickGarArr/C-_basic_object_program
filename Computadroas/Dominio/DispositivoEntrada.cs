using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class DispositivoEntrada
    {
        protected string tipoEntrada { set; get; }
        protected string marca { set; get; }
        public DispositivoEntrada()
        {

        }

        public DispositivoEntrada(string tipoEntrada, string marca)
        {
            this.tipoEntrada = tipoEntrada;
            this.marca = marca;
        }

        public override string ToString()
        {
            return string.Format("tipo Entrada: {0}, marca: {1}", tipoEntrada, marca);
        }
    }

}
