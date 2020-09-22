using System;

namespace IEnumarable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos la tienda
            CTiendaAutos tienda = new CTiendaAutos();

            //Recorremos cada uno de los elementos de la estructura que expone

            foreach(CAuto auto in tienda)
            {
                auto.CalculaTenenencia(0.05);
                auto.MuestraInformacion();
            }
        }
    }
}
