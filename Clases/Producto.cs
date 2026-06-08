using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class Producto
    {
        string nombre = string.Empty;
        string codigo = string.Empty;
        string preciobase = string.Empty ;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Preciobase { get => preciobase; set => preciobase = value; }

    }
}
