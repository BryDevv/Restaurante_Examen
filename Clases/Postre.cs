using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class Postre : Producto
    { 
        public bool EsDulce { get; set; }
        public string Porcion { get; set; } = string.Empty;
    }
}
