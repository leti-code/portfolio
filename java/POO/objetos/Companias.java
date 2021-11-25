package Portfolio;

public class Companias {
	protected String nombre, telefono;
	
	public Companias() {
		nombre = "Compa�ia random";
		telefono = "901123123";
	}
	
	public Companias(String nom, String tlf) {
		nombre = nom;
		telefono = tlf;
	}
	
	public void imprimir() {
		System.out.println("*****Datos de la compa�ia******");
		System.out.println("Nombre: " + nombre);
		System.out.println("Tel�fono: " + telefono);
	}

}
