package Portfolio;

public class Asegurados extends Personas {
	protected String direccion;
	protected Categorias categoria;
	
	public Asegurados() {
		direccion = "Inventada";
		categoria = new Categorias();
	}
	
	/*EN EL APARTADO ASEGURADOS NO SE PIDE CONSTRUCTOR CON PARAMETROS
	 * PERO EN EL APARTADO EJECUTAR SI HACE REFERENCIA A INSTANCIAR UN 
	 * ASEGURADO CON PARAMETROS, POR LO QUE SE HA CREADO EL CONSTRUCTOR CON PARAMETROS*/
	
	public Asegurados(String nom, String tlf, String dir) {
		super(nom, tlf);
		direccion = dir;
		categoria = new Categorias();
	}
	@Override
	public String obtenerTipo() {
		return "asegurado";
	}
	
	public void imprimir() {
		super.imprimir();
		System.out.println("Datos del asegurado: ");
		System.out.println("Direccción: " + direccion);
		System.out.println(categoria.toString());
	}
	
	private class Categorias{
		protected String nombre;
		protected double cuota;
		
		public Categorias(){
			nombre = "Premium";
			cuota = 1000;
		}
		
		public double precioDescuento() {
			return (cuota - (cuota * 0.2));
		}

		@Override
		public String toString() {
			return "Categoria: \n Nombre: " + nombre + "\n Cuota: " + cuota;
		}
		
		
		
	}

}
