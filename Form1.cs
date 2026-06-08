using Restaurante_Examen.Clases;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Restaurante_Examen
{
    public partial class Form1 : Form
    {
        private List<Bebida> listaBebidas = new List<Bebida>();
        private List<PlatoFuerte> listaPlatos = new List<PlatoFuerte>();
        private List<Postre> listaPostres = new List<Postre>();
        
        private BindingList<Producto> carritoCompras = new BindingList<Producto>();

        public Form1()
        {
            InitializeComponent();
            CargarDatos();
            CargarCarritoJson();
            ConfigurarEventos();
            InicializarUI();
            InicializarUI_Agregar();
            ConfigurarCarrito();
        }

        private void GuardarProductosJson()
        {
            try
            {
                var todosLosProductos = new List<Producto>();
                todosLosProductos.AddRange(listaBebidas);
                todosLosProductos.AddRange(listaPlatos);
                todosLosProductos.AddRange(listaPostres);

                string jsonString = JsonSerializer.Serialize(todosLosProductos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("productos.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar productos: " + ex.Message);
            }
        }

        private void ConfigurarCarrito()
        {
            carrito.AutoGenerateColumns = false;
            carrito.Columns.Clear();
            carrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "Producto", Width = 100 });
            carrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoría", Width = 80 });
            
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "PrecioDisplay";
            carrito.Columns.Add(colPrecio);

            carrito.DataSource = carritoCompras;
            
            carrito.CellFormatting += (s, e) => {
                if (e.RowIndex >= 0 && e.RowIndex < carrito.Rows.Count) {
                    if (carrito.Columns[e.ColumnIndex].Name == "PrecioDisplay") {
                        var prod = carrito.Rows[e.RowIndex].DataBoundItem as Producto;
                        if (prod != null) e.Value = "Q" + prod.Preciobase.ToString("F2");
                    }
                }
            };
        }

        private void GuardarCarritoJson()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(carritoCompras.ToList(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("carrito.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el carrito: " + ex.Message);
            }
        }

        private void CargarCarritoJson()
        {
            try
            {
                if (File.Exists("carrito.json"))
                {
                    string jsonString = File.ReadAllText("carrito.json");
                    var lista = JsonSerializer.Deserialize<List<Producto>>(jsonString) ?? new List<Producto>();
                    foreach(var item in lista) carritoCompras.Add(item);
                }
            }
            catch { }
        }

        private void CargarDatos()
        {
            try
            {
                if (File.Exists("productos.json"))
                {
                    string jsonString = File.ReadAllText("productos.json");
                    using (JsonDocument doc = JsonDocument.Parse(jsonString))
                    {
                        foreach (JsonElement element in doc.RootElement.EnumerateArray())
                        {
                            string categoria = element.GetProperty("Categoria").GetString() ?? "";
                            if (categoria.Equals("Bebida", StringComparison.OrdinalIgnoreCase))
                                listaBebidas.Add(JsonSerializer.Deserialize<Bebida>(element.GetRawText())!);
                            else if (categoria.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase))
                                listaPlatos.Add(JsonSerializer.Deserialize<PlatoFuerte>(element.GetRawText())!);
                            else if (categoria.Equals("Postre", StringComparison.OrdinalIgnoreCase))
                                listaPostres.Add(JsonSerializer.Deserialize<Postre>(element.GetRawText())!);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar productos: " + ex.Message); }
        }

        private void ConfigurarEventos()
        {
            menu.SelectedIndexChanged += (s, e) => {
                string seleccion = menu.SelectedItem?.ToString() ?? "";
                if (seleccion.Equals("Bebida", StringComparison.OrdinalIgnoreCase)) {
                    P_bebida.Visible = true; P_platofuerte.Visible = false; Postre.Visible = false;
                } else if (seleccion.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase)) {
                    P_bebida.Visible = true; P_platofuerte.Visible = true; P_platofuerte.BringToFront(); Postre.Visible = false;
                } else if (seleccion.Equals("Postre", StringComparison.OrdinalIgnoreCase)) {
                    P_bebida.Visible = false; Postre.Visible = true;
                }
                ActualizarTodoPrecio();
            };

            aceptar.Click += button1_Click;
            
            tipobebida.SelectedIndexChanged += (s, e) => { ActualizarNombresBebida(); ActualizarTodoPrecio(); };
            nombrebebida.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();
            presentacionml.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();

            tipocarne.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();
            acopañamiento.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();

            tipopostre.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();
            azucar.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();
            presentacion_postre.SelectedIndexChanged += (s, e) => ActualizarTodoPrecio();

            // Eventos para Pestaña Agregar
            cmbTipoNuevo.SelectedIndexChanged += (s, e) => ActualizarPanelesAgregar();
            btnGuardarNuevo.Click += (s, e) => GuardarNuevoProducto();
        }

        private void InicializarUI_Agregar()
        {
            cmbTipoNuevo.Items.Clear();
            cmbTipoNuevo.Items.AddRange(new string[] { "Bebida", "Plato fuerte", "Postre" });
            cmbTipoNuevo.SelectedIndex = 0;

            // Bebidas
            cmbTipoBebidaNuevo.Items.Clear();
            cmbTipoBebidaNuevo.Items.AddRange(new string[] { "Agua", "Refresco", "Cerveza" });
            cmbPresentacionBebidaNuevo.Items.Clear();
            cmbPresentacionBebidaNuevo.Items.AddRange(new string[] { "12oz", "16oz", "600ml", "1L" });
            
            // Platos
            cmbCarneNuevo.Items.Clear();
            cmbCarneNuevo.Items.AddRange(new string[] { "Res", "Pollo", "Cerdo", "Mixto" });
            cmbAcompañamientoNuevo.Items.Clear();
            cmbAcompañamientoNuevo.Items.AddRange(new string[] { "Papas", "Chirmol", "Ensalada", "Arroz" });

            // Postres
            cmbAzucarNuevo.Items.Clear();
            cmbAzucarNuevo.Items.AddRange(new string[] { "Sí", "No" });
            cmbPresentacionPostreNuevo.Items.Clear();
            cmbPresentacionPostreNuevo.Items.AddRange(new string[] { "Pequeño", "Mediano", "Grande", "Personal" });

            ActualizarPanelesAgregar();
        }

        private void ActualizarPanelesAgregar()
        {
            string seleccion = cmbTipoNuevo.SelectedItem?.ToString() ?? "";
            
            pnlBebidaNuevo.Visible = false;
            pnlPlatoNuevo.Visible = false;
            pnlPostreNuevo.Visible = false;

            cmbNombreNuevo.Items.Clear();

            if (seleccion.Equals("Bebida", StringComparison.OrdinalIgnoreCase)) {
                pnlBebidaNuevo.Visible = true;
                cmbNombreNuevo.Items.AddRange(new string[] { "Coca Cola", "Pepsi", "Gallo", "Modelo", "Agua Pura" });
            } else if (seleccion.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase)) {
                pnlBebidaNuevo.Visible = true;
                pnlPlatoNuevo.Visible = true;
                pnlPlatoNuevo.BringToFront();
                cmbNombreNuevo.Items.AddRange(new string[] { "Carne Asada", "Pollo Frito", "Hamburguesa", "Tacos" });
            } else if (seleccion.Equals("Postre", StringComparison.OrdinalIgnoreCase)) {
                pnlPostreNuevo.Visible = true;
                cmbNombreNuevo.Items.AddRange(new string[] { "Helado", "Pastel de Chocolate", "Pie de Limón", "Flan" });
            }
            
            if (cmbNombreNuevo.Items.Count > 0) cmbNombreNuevo.SelectedIndex = 0;
            
            if (cmbTipoBebidaNuevo.Items.Count > 0) cmbTipoBebidaNuevo.SelectedIndex = 0;
            if (cmbPresentacionBebidaNuevo.Items.Count > 0) cmbPresentacionBebidaNuevo.SelectedIndex = 0;
            if (cmbCarneNuevo.Items.Count > 0) cmbCarneNuevo.SelectedIndex = 0;
            if (cmbAcompañamientoNuevo.Items.Count > 0) cmbAcompañamientoNuevo.SelectedIndex = 0;
            if (cmbAzucarNuevo.Items.Count > 0) cmbAzucarNuevo.SelectedIndex = 0;
            if (cmbPresentacionPostreNuevo.Items.Count > 0) cmbPresentacionPostreNuevo.SelectedIndex = 0;
        }

        private void GuardarNuevoProducto()
        {
            try {
                string tipo = cmbTipoNuevo.SelectedItem?.ToString() ?? "";
                string nombre = cmbNombreNuevo.Text;
                string codigo = txtCodigoNuevo.Text;
                
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(txtPrecioNuevo.Text)) {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return;
                }

                double precio = double.Parse(txtPrecioNuevo.Text);

                if (tipo.Equals("Bebida", StringComparison.OrdinalIgnoreCase)) {
                    Bebida b = new Bebida {
                        Nombre = nombre, Codigo = codigo, Preciobase = precio, Categoria = "Bebida",
                        TipoBebida = cmbTipoBebidaNuevo.Text, Volumen = cmbPresentacionBebidaNuevo.Text
                    };
                    listaBebidas.Add(b);
                } else if (tipo.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase)) {
                    PlatoFuerte p = new PlatoFuerte {
                        Nombre = nombre, Codigo = codigo, Preciobase = precio, Categoria = "Plato fuerte",
                        TipoCarne = cmbCarneNuevo.Text, Acompañamiento = cmbAcompañamientoNuevo.Text
                    };
                    listaPlatos.Add(p);
                } else if (tipo.Equals("Postre", StringComparison.OrdinalIgnoreCase)) {
                    Postre po = new Postre {
                        Nombre = nombre, Codigo = codigo, Preciobase = precio, Categoria = "Postre",
                        EsDulce = cmbAzucarNuevo.Text.Equals("Sí", StringComparison.OrdinalIgnoreCase),
                        Porcion = cmbPresentacionPostreNuevo.Text
                    };
                    listaPostres.Add(po);
                }

                GuardarProductosJson();
                MessageBox.Show("Producto agregado exitosamente.");
                
                // Limpiar campos
                txtCodigoNuevo.Clear();
                txtPrecioNuevo.Clear();
                
                // Refrescar Menú
                InicializarUI();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void InicializarUI()
        {
            P_bebida.Visible = false;
            P_platofuerte.Visible = false;
            Postre.Visible = false;

            // Población de ComboBoxes del Menú con opciones estándar + datos cargados
            tipobebida.Items.Clear();
            var tiposBebidaBase = new string[] { "Agua", "Refresco", "Cerveza" };
            var tiposBebidaCargados = listaBebidas.Select(b => b.TipoBebida).Distinct();
            tipobebida.Items.AddRange(tiposBebidaBase.Union(tiposBebidaCargados, StringComparer.OrdinalIgnoreCase).ToArray());

            presentacionml.Items.Clear();
            var volBase = new string[] { "12oz", "16oz", "600ml", "1L" };
            var volCargados = listaBebidas.Select(b => b.Volumen).Distinct();
            presentacionml.Items.AddRange(volBase.Union(volCargados, StringComparer.OrdinalIgnoreCase).ToArray());

            tipocarne.Items.Clear();
            var carneBase = new string[] { "Res", "Pollo", "Cerdo", "Mixto" };
            var carneCargados = listaPlatos.Select(p => p.TipoCarne).Distinct();
            tipocarne.Items.AddRange(carneBase.Union(carneCargados, StringComparer.OrdinalIgnoreCase).ToArray());

            acopañamiento.Items.Clear();
            var acoBase = new string[] { "Papas", "Chirmol", "Ensalada", "Arroz" };
            var acoCargados = listaPlatos.Select(p => p.Acompañamiento).Distinct();
            acopañamiento.Items.AddRange(acoBase.Union(acoCargados, StringComparer.OrdinalIgnoreCase).ToArray());

            tipopostre.Items.Clear();
            var postresCargados = listaPostres.Select(p => p.Nombre).Distinct();
            tipopostre.Items.AddRange(postresCargados.ToArray());
            if (tipopostre.Items.Count == 0) tipopostre.Items.AddRange(new string[] { "Helado", "Pastel", "Flan" });

            azucar.Items.Clear();
            azucar.Items.AddRange(new object[] { "Sí", "No" });

            presentacion_postre.Items.Clear();
            var porcionBase = new string[] { "Pequeño", "Mediano", "Grande", "Personal" };
            var porcionCargada = listaPostres.Select(p => p.Porcion).Distinct();
            presentacion_postre.Items.AddRange(porcionBase.Union(porcionCargada, StringComparer.OrdinalIgnoreCase).ToArray());

            // Seleccionar primeros elementos por defecto
            if (menu.Items.Count > 0) menu.SelectedIndex = 0;
            if (tipobebida.Items.Count > 0) tipobebida.SelectedIndex = 0;
            if (presentacionml.Items.Count > 0) presentacionml.SelectedIndex = 0;
            if (tipocarne.Items.Count > 0) tipocarne.SelectedIndex = 0;
            if (acopañamiento.Items.Count > 0) acopañamiento.SelectedIndex = 0;
            if (tipopostre.Items.Count > 0) tipopostre.SelectedIndex = 0;
            if (azucar.Items.Count > 0) azucar.SelectedIndex = 0;
            if (presentacion_postre.Items.Count > 0) presentacion_postre.SelectedIndex = 0;

            ActualizarNombresBebida();
            ActualizarTodoPrecio();
        }

        private void ActualizarNombresBebida()
        {
            string tipo = tipobebida.SelectedItem?.ToString() ?? "";
            nombrebebida.Items.Clear();
            var nombres = listaBebidas.Where(p => p.TipoBebida.Equals(tipo, StringComparison.OrdinalIgnoreCase)).Select(p => p.Nombre).Distinct().ToArray();
            nombrebebida.Items.AddRange(nombres);
            if (nombrebebida.Items.Count > 0) nombrebebida.SelectedIndex = 0;
        }

        private void ActualizarTodoPrecio()
        {
            string seleccion = menu.SelectedItem?.ToString() ?? "";
            double precioActual = 0;

            if (seleccion.Equals("Bebida", StringComparison.OrdinalIgnoreCase)) {
                var p = GetSelectedBebida();
                precioActual = p?.Preciobase ?? 0;
                preciobebida.Text = "Precio: Q" + precioActual.ToString("F2");
            } else if (seleccion.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase)) {
                var p = GetSelectedPlato();
                precioActual = p?.Preciobase ?? 0;
                preciocarne.Text = "Precio: Q" + precioActual.ToString("F2");
            } else if (seleccion.Equals("Postre", StringComparison.OrdinalIgnoreCase)) {
                var p = GetSelectedPostre();
                precioActual = p?.Preciobase ?? 0;
                label4.Text = "Precio: Q" + precioActual.ToString("F2");
            }

            lblPrecioSeleccionado.Text = "Precio: Q" + precioActual.ToString("F2");
        }

        private Bebida? GetSelectedBebida() {
            string tipo = tipobebida.SelectedItem?.ToString() ?? "";
            string nombre = nombrebebida.SelectedItem?.ToString() ?? "";
            string volumen = presentacionml.SelectedItem?.ToString() ?? "";
            return listaBebidas.FirstOrDefault(p => p.TipoBebida.Equals(tipo, StringComparison.OrdinalIgnoreCase) && p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && p.Volumen.Equals(volumen, StringComparison.OrdinalIgnoreCase));
        }

        private PlatoFuerte? GetSelectedPlato() {
            string tipo = tipocarne.SelectedItem?.ToString() ?? "";
            string aco = acopañamiento.SelectedItem?.ToString() ?? "";
            return listaPlatos.FirstOrDefault(p => p.TipoCarne.Equals(tipo, StringComparison.OrdinalIgnoreCase) && p.Acompañamiento.Equals(aco, StringComparison.OrdinalIgnoreCase));
        }

        private Postre? GetSelectedPostre() {
            string tipo = tipopostre.SelectedItem?.ToString() ?? "";
            string tamano = presentacion_postre.SelectedItem?.ToString() ?? "";
            bool esDulce = (azucar.SelectedItem?.ToString() ?? "").Equals("Sí", StringComparison.OrdinalIgnoreCase);
            return listaPostres.FirstOrDefault(p => p.Nombre.Equals(tipo, StringComparison.OrdinalIgnoreCase) && p.Porcion.Equals(tamano, StringComparison.OrdinalIgnoreCase) && p.EsDulce == esDulce);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            string seleccion = menu.SelectedItem?.ToString() ?? "";
            Producto? p = null;

            if (seleccion.Equals("Bebida", StringComparison.OrdinalIgnoreCase)) p = GetSelectedBebida();
            else if (seleccion.Equals("Plato fuerte", StringComparison.OrdinalIgnoreCase)) p = GetSelectedPlato();
            else if (seleccion.Equals("Postre", StringComparison.OrdinalIgnoreCase)) p = GetSelectedPostre();

            if (p != null) {
                carritoCompras.Add(p);
                GuardarCarritoJson();
                MessageBox.Show($"{p.Nombre} agregado al carrito.");
            } else MessageBox.Show("Por favor seleccione un producto válido.");
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void P_bebida_Paint(object sender, PaintEventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void preciocarne_Click(object sender, EventArgs e) { }
    }
}
