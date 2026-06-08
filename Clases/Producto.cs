using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante_Examen.Clases
{
    internal class Producto
    {
        string nombre = string.Empty;
        string codigo = string.Empty;
        double preciobase = 0;
        string categoria = string.Empty; // Bebida, Plato fuerte, Postre

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public double Preciobase { get => preciobase; set => preciobase = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public override string ToString() => Nombre;
    }
}
