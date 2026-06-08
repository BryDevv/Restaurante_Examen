using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class Postre : Producto
    { 
        bool esDulce = false;

        string porcion = string.Empty;

        public bool EsDulce { get => esDulce; set => esDulce = value; }
        public string Porcion { get => porcion; set => porcion = value; }

    }
}
