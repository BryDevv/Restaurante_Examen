using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases 
{
    internal class Bebida : Producto
    {
        string volumen = string.Empty;  
        string tipo = string.Empty; 

        public string Volumen { get => volumen; set => volumen = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
