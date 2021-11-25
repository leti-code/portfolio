
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionFacturas
{
    /*Esta es la clase Program que contiene el método main desde el cual se ejecuta el programa completo*/
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static Inicio inicio;
        public static Crear create;
        public static List<Factura> facturas;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            create = new Crear();
            create.Hide();
            facturas = new List<Factura>();
            Application.Run(inicio = new Inicio());

        }

    }
}
