using System;
using System.Collections.Generic;
using System.Text;

namespace Computadroas
{
    class Orden
    {
        private const int MAX_COMP = 10;
        private static int contador;
        private int contadorComputadoras { get; set; }
        private int idOreden { get; }
        private Computadora[] computadoras { get; }

        public Orden() {
            idOreden = ++contador;
            computadoras = new Computadora[MAX_COMP];
        }

        public bool agregarComputadora(Computadora computadora)
        {
            if(contadorComputadoras < MAX_COMP)
            {
                computadoras[contadorComputadoras++] = computadora;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("idOrden: ").Append(idOreden);
            sb.Append("Computadoras: ").Append("\n");
            for(int i = 0; i < contadorComputadoras; i++)
            {
                sb.Append(computadoras[i].ToString());
            }
            return sb.ToString();
        }

        public Computadora[] GetComputadoras()
        {
            return computadoras;
        }
    }
}
