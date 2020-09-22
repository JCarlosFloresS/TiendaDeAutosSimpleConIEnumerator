using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumarable
{
    class CAuto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        //Cosntructor
        public CAuto(string pModelo, double pCosto)
        {
            //Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        //Metodos Interfaz
        public void CalculaTenenencia(double imp)
        {
            //Calculamos el impuesto
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            //Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
