using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionFacturas
{
    /*La clase producto almacenará las propiedades que tiene cada uno de los productos facturables:
        - Referencia
        - Nombre del producto
        - Precio por unidad
        - Cantidad
    */
    public class Producto
    {
        public String refProd, nomProd;
        public int cantidad;
        public double precio, totalSinImpuestos;

        public Producto()
        {
            refProd = Program.create.tRef.Text;
            nomProd = Program.create.tNombre.Text;
            cantidad = Program.create.cantidad;
            precio = Program.create.precio;
            totalSinImpuestos = cantidad * precio;
        }
    }
}
