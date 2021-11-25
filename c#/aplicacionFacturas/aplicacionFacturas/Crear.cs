using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace aplicacionFacturas
{
    public partial class Crear : Form
    {
        public int numFactura;
        public List<Producto> productos;
        public int iva, irpf, cantidad;
        public double precio;
        public DateTime fecFactura;

        public Crear()
        {
            InitializeComponent();
            numFactura = 1;
            productos = new List<Producto>();

            //Los siguientes elementos gráficos adquieren un valor predeterminado por la aplicación y no modificable por el usuario:
            //Número de la factura: para que sirva de identificador único (se incrementará al guardar una factura)
            tNum.Text = numFactura.ToString();
            //Fecha de factura
            fecFactura = DateTime.Today;
            tDate.Text = fecFactura.ToString("d");
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.inicio.Show();
        }



        private void bNuevoProd_Click(object sender, EventArgs e)
        {
            if (!validarProducto()){
                MessageBox.Show("Alguno de los campos del producto está incompleto. Por favor revise y rellene todos los campos.");
            }else{
                guardarProducto();
            }

        }

        private bool validarProducto()
        {
            if (this.tRef.Text.Length == 0 || this.tNombre.Text.Length == 0 || this.tCant.Text.Length == 0 || this.tPrecio.Text.Length == 0)
            {
                return false;
            }
            return true; // Si no se ha encontrado ningún campo vacío devolvemos True (es un producto válido).
        }

        private void guardarProducto()
        {
            String auxCant = this.tCant.Text.ToString();
            try
            {
                cantidad = Int32.Parse(auxCant);
            }
            catch
            {
                /*Para evitar fallos de casteo se aplicaría, por defecto, una cantidad de 1 al realizar los cálculos*/
                MessageBox.Show("No ha introducido un dato válido en 'Cantidad'. Por defecto se asume que es 1");
                cantidad = 1;
            }

            String auxPrecio = this.tPrecio.Text.ToString();
            try
            {
                precio = Double.Parse(auxPrecio);
            }
            catch
            {
                /*Para evitar fallos de casteo se aplica, por defecto, un precio de 1 al realizar los cálculos*/
                MessageBox.Show("No ha introducido un dato válido en 'Precio'. Por defecto se asume que es 1");
                precio = 1;
            }
            Producto prodAuxiliar = new Producto();
            productos.Add(prodAuxiliar);
            //Limpiamos la ventana de información del producto para facilitar que el usuario introduzca nuevos datos
            limpiarProducto();
        }

        //Método que limpia la sección del Producto
        public void limpiarProducto()
        {
            this.tRef.Text = "";
            this.tNombre.Text = "";
            this.tCant.Text = "";
            this.tPrecio.Text = "";
        }



        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Alguno de los campos está incompleto. Por favor revise y rellene todos los campos.");

            }else{
                guardarProducto();
            
                iva = sacarIva();
                if (this.cbIrpf.SelectedItem != null)
                {
                    irpf = Int32.Parse(this.cbIrpf.SelectedItem.ToString());
                }
                else
                {
                    /*En caso de que no haya elegido un valor, para evitar fallos de parseo se aplica, por defecto, un 0% de IRPF al realizar los cálculos*/
                    MessageBox.Show("No ha introducido valor para el IRPF, por defecto se aplicará IRPF del 0%");
                    irpf = 0;
                }

                Factura factAux = new Factura();
                Program.facturas.Add(factAux);

                //Método que creará una ventana emergente para mostrar los datos
                mostrarFactura();

                numFactura++;

                //Limpiamos los valores que aparecen en el formulario
                limpiarPantalla();

                //Eliminamos el contenido de la lista de productos (para que no haya problema en las siguientes facturas)
                productos.Clear();
            }
        }

        private bool validar(){
            /*Este método devolverá false (formulario no válido) en el caso de que algún campo no se haya completado
             No aplicamos en este método el IVA ni el IRPF (en caso de no seleccionar una opción se aplicaría un 0%, lo cual se gestiona en otro método)*/
            //Comprobación de los datos del emisor de la factura
            if (this.tIdEmisor.Text.Length == 0 || this.tNombreEmisor.Text.Length == 0 || this.tDireccionEmisor.Text.Length == 0)
            {
                return false;
            }

            //Comprobación de los datos del receptor de la factura
            if (this.tIdReceptor.Text.Length == 0 || this.tNombreReceptor.Text.Length == 0 || this.tDireccionReceptor.Text.Length == 0)
            {
                return false;
            }
            if (!validarProducto())
            {
                return false;
            }
            return true; // Si no se ha encontrado ningún campo vacío devolvemos True (es un formulario válido).
        }

        public int sacarIva()
        {
            int resul = 0;
            if (this.cbIva.SelectedItem != null){
                String aux = this.cbIva.SelectedItem.ToString();
                String[] helper = aux.Split(' ');
                aux = helper[1];
                resul = Int32.Parse(aux);
            }else{
                /*En caso de que no haya elegido un valor, para evitar fallos de parseo se aplica, por defecto, un 0% de IVA al realizar los cálculos*/
                MessageBox.Show("No ha introducido valor para el IVA, por defecto se aplicará IVA del 0%");
            }
            return resul;
        }

        //Método que crea una nueva instancia de la clase Mostrar para enseñar los datos de la factura actual.
        public void mostrarFactura()
        {
            //En la instancia pasamos el índice de la factura para que saque su información
            Mostrar most = new Mostrar(Program.facturas.Count() - 1);
            most.Show();
        }

        public void limpiarPantalla()
        {
            this.tIdEmisor.Text = "";
            this.tIdReceptor.Text = "";
            this.tNombreEmisor.Text = "";
            this.tNombreReceptor.Text = "";
            this.tDireccionEmisor.Text = "";
            this.tDireccionReceptor.Text = "";
            
            this.tCompra.Value = DateTime.Today;
            this.cbIva.SelectedItem = null;
            this.cbIrpf.SelectedItem = null;
            limpiarProducto();
            tNum.Text = numFactura.ToString();
            fecFactura = DateTime.Today;
            tDate.Text = fecFactura.ToString("d");
        }
    }
}
