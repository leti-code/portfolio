using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionFacturas
{
    class Factura
    {
        public int numFact; //Número de la factura
        public DateTime fecFact, fecComp;
        public String idEmi, nombreEmi, direccionEmi, idRec, nombreRec, direccionRec;
        public int iva, irpf;
        public List<Producto> productos;
        public double totalSinImpuestos, total;

        public Factura()
        {
            numFact = Program.create.numFactura;
            fecFact = Program.create.fecFactura;

            idEmi = Program.create.tIdEmisor.Text;
            nombreEmi = Program.create.tNombreEmisor.Text;
            direccionEmi = Program.create.tDireccionEmisor.Text;

            idRec = Program.create.tIdReceptor.Text;
            nombreRec = Program.create.tNombreReceptor.Text;
            direccionRec = Program.create.tDireccionReceptor.Text;


            productos = new List<Producto>();
            for(int i = 0; i < Program.create.productos.Count(); i++)
            {
                productos.Add(Program.create.productos[i]);
            }

            fecComp = Program.create.tCompra.Value;
            iva = Program.create.iva;
            irpf = Program.create.irpf;

            calcularTotalProds();

        }

        public void calcularTotalProds() {
            totalSinImpuestos = 0;
            for (int i = 0; i < productos.Count(); i++)
            {
                totalSinImpuestos += productos[i].totalSinImpuestos;
            }

            total = totalSinImpuestos + (totalSinImpuestos * iva / 100) - (totalSinImpuestos * irpf /100);
        }
    }
}
