using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases 
{
    internal class Bebida : Producto
    {
        public string TipoBebida { get; set; } = string.Empty;
        public string Volumen { get; set; } = string.Empty;
    }
}
