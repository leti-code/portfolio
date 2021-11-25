using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionFacturas
{
    /*Clase que genera una ventana de búsqueda de facturas ya creadas en la ejecución del programa*/
    public partial class Buscar : Form
    {

        public Buscar()
        {
            InitializeComponent();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Program.inicio.Show();
            this.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            int numFactura = Decimal.ToInt32(numFact.Value);

            if(numFactura < 1 || numFact.Value > Program.facturas.Count()){
                MessageBox.Show("No ha introducido un número de factura válido. Pruebe de nuevo");
                numFact.Value = 1;
            }else{
                Mostrar show = new Mostrar(numFactura - 1);
                show.Show();
                this.Close();
            }

        }
    }
}
