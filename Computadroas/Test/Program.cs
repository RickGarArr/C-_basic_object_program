using System;

namespace Computadroas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse1 = new Mouse("USB", "DELL");
            Mouse mouse2 = new Mouse("Bluethoot", "DELL");
            Teclado teclado1 = new Teclado("USB", "IBM");
            Teclado teclado2 = new Teclado("Bluethoot", "IBM");
            Monitor monitor1 = new Monitor("DELL", 15);
            Monitor monitor2 = new Monitor("DELL", 14.5);

            var computadora1 = new Computadora(mouse1, teclado1, monitor1);
            var computadora2 = new Computadora(mouse2, teclado2, monitor2);

            var order1 = new Orden();
            order1.agregarComputadora(computadora1);
            order1.agregarComputadora(computadora1);

            var order2 = new Orden();
            order2.agregarComputadora(computadora2);
            order2.agregarComputadora(computadora1);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
        }
    }
}
