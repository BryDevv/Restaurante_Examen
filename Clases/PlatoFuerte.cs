using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class PlatoFuerte
    {

        string guarnicion = string.Empty;
        string acompañamiento = string.Empty;   


        public string Guarnicion { get => guarnicion; set => guarnicion = value; }
        
        public string Acompañamiento { get => acompañamiento; set => acompañamiento = value; }


    }
}
