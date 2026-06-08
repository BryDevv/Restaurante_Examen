using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class PlatoFuerte : Producto
    {
        public string TipoCarne { get; set; } = string.Empty;
        public string Acompañamiento { get; set; } = string.Empty;
    }
}
