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
    public partial class Mostrar : Form
    {
        public Mostrar(int p)
        {
            InitializeComponent();


            lNum.Text += Program.facturas[p].numFact.ToString();
            lFecFac.Text += Program.facturas[p].fecFact.ToString("d");

            lIdEmi.Text += Program.facturas[p].idEmi;
            lNomEmi.Text += Program.facturas[p].nombreEmi;
            lDirEmi.Text += Program.facturas[p].direccionEmi;

            lIdRec.Text += Program.facturas[p].idRec;
            lNomRec.Text += Program.facturas[p].nombreRec;
            lDirRec.Text += Program.facturas[p].direccionRec;


            lFecCompra.Text += Program.facturas[p].fecComp.ToString("d");


            /*Creamos un booleano que nos ayude a saber si ya se ha rellenado alguna línea.
             Esto se hace porque la tabla no nos permite iniciarla con un RowCount de 0.
            Por esto, lo inicializamos a 1, pero cuando metamos el primer producto, no queremos que cree una nueva línea, sino sólo que añada la información*/
            bool primera_linea = true;
            for (int i = 0; i < Program.facturas[p].productos.Count(); i++)
            {
                /*Si no es la primera línea, tenemos que añadir una nueva línea y establecer el tamaño/proporción de ésta*/
                if (!primera_linea)
                {
                    this.tablaProductos.RowCount = tablaProductos.RowCount + 1;
                    this.tablaProductos.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30F));
                }

                //Insertamos en cada celda de esa fila la información correspondiente del producto 
                this.tablaProductos.Controls.Add(new Label() { Text = Program.facturas[p].productos[i].refProd , TextAlign= System.Drawing.ContentAlignment.MiddleRight }, 0, tablaProductos.RowCount - 1);
                this.tablaProductos.Controls.Add(new Label() { Text = Program.facturas[p].productos[i].nomProd, TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 1, tablaProductos.RowCount - 1);
                this.tablaProductos.Controls.Add(new Label() { Text = Program.facturas[p].productos[i].precio.ToString() + "$", TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 2, tablaProductos.RowCount - 1);
                this.tablaProductos.Controls.Add(new Label() { Text = Program.facturas[p].productos[i].cantidad.ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 3, tablaProductos.RowCount - 1);
                //En el caso de los datos numéricos, primero lo calculamos y posteriormente se añade a la tabla su valor casteado a cadena
                double ivaAux = Math.Round(Program.facturas[p].productos[i].totalSinImpuestos * Program.facturas[p].iva / 100, 2);
                this.tablaProductos.Controls.Add(new Label() { Text = ivaAux.ToString() + "$", TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 4, tablaProductos.RowCount - 1);
                double irpfAux = Math.Round(Program.facturas[p].productos[i].totalSinImpuestos * Program.facturas[p].irpf / 100 * -1, 2);
                this.tablaProductos.Controls.Add(new Label() { Text = irpfAux.ToString() + "$", TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 5, tablaProductos.RowCount - 1);
                double totalProd = Math.Round(Program.facturas[p].productos[i].totalSinImpuestos + ivaAux + irpfAux, 2);
                this.tablaProductos.Controls.Add(new Label() { Text = totalProd.ToString() + "$", TextAlign = System.Drawing.ContentAlignment.MiddleRight }, 6, tablaProductos.RowCount - 1);

                //Una vez acabamos de meter una línea seteamos el booleano a falso para indicar que al menos ya se ha rellenado una fila (y que por tanto será necesario en posteriores iteraciones, generar una fila nueva)
                primera_linea = false;
            }



            //Cuadro de totales
            lTotSinImp.Text = Program.facturas[p].totalSinImpuestos.ToString() + "$";
            double totIva = Program.facturas[p].totalSinImpuestos * Program.facturas[p].iva / 100;
            lIvaE.Text = totIva.ToString() + "$";
            lIvaP.Text = "(" + Program.facturas[p].iva.ToString() + "%)";

            double totIrpf = Program.facturas[p].totalSinImpuestos * Program.facturas[p].irpf / 100 * -1;
            lIrpfE.Text = totIrpf.ToString() + "$";
            lIrpfP.Text = "(" + Program.facturas[p].irpf.ToString() + "%)";

            lTotConImp.Text = Program.facturas[p].total.ToString() + "$";


        }

        //Método que permite volver a mostrar la ventana de creación 
        private void bCrear_Click(object sender, EventArgs e)
        {
            Program.create.Show();
            this.Close();
        }

        //Método que vuelve a la ventana de inicio 
        private void bInicio_Click(object sender, EventArgs e)
        {
            Program.inicio.Show();
            this.Close();
        }


        //Método que va a ventana de búsqueda
        private void bBuscar_Click(object sender, EventArgs e)
        {
            Buscar search = new Buscar();
            search.Show();
            this.Close();

        }
    }
}
