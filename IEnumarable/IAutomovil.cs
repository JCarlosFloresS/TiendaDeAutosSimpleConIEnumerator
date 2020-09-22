using System;
using System.Collections.Generic;
using System.Text;

namespace IEnumarable
{
    interface IAutomovil
    {
        //Calcular el impuesto
        void CalculaTenenencia(double imp);

        //Mostrrar informacion
        void MuestraInformacion();
    }
}
