package Portfolio;

import java.util.Scanner;

public class Hospital {
	protected int codigo, telefono;
	protected String nombre;
	private Scanner t;
	
	

	public Hospital() {
		t = new Scanner(System.in);
		modificar();
	}
	
	public Hospital(int cod, int tlf, String nom) {
		t = new Scanner(System.in);
		modificar(cod, tlf, nom);
		/*Aunque no se especifica que se tenga que usar el m�todo, s� se pide el m�todo sobrecargado
		 * y por tanto se ha considerado m�s conveniente utilizarlo en el constructor con par�metros*/
	}
	
	public void modificar() {
		System.out.println("Modificando datos de hospital...");
		System.out.println("Introduce el c�digo");
		setCodigo(t.nextInt());
		System.out.println("Introduce el tel�fono");
		setTelefono(t.nextInt());
		System.out.println("Introduce el nombre");
		setNombre(t.next());
	}
	
	public void modificar(int cod, int tlf, String nom) {
		System.out.println("Modificando datos de hospital...");
		setCodigo(cod);
		setTelefono(tlf);
		setNombre(nom);
	}

	public void imprimir() {
		System.out.println("*****Datos del hospital*****");
		System.out.println("C�digo: " + getCodigo());
		System.out.println("Tel�fono: " + getTelefono());
		System.out.println("Nombre: " + getNombre());
	}
	public int getCodigo() {return codigo;}
	public void setCodigo(int codigo) {	
		while (codigo > 1000 || codigo < 0) {
			System.out.println("No ha introducido un c�digo v�lido");
			System.out.println("El c�digo no debe superar el valor mil ni ser negativo");
			System.out.println("Introduzca un nuevo valor");
			codigo = t.nextInt();
		}
		this.codigo = codigo;}
	public int getTelefono() {return telefono;}
	public void setTelefono(int telefono) {
		while (telefono < 100000000 || telefono > 999999999) {
			System.out.println("El n�mero tiene que tener 9 d�gitos obligatoriamente. Introduzca el n�mero de nuevo");
			telefono = t.nextInt();
		}
		this.telefono = telefono;	}
	public String getNombre() {	return nombre;}
	public void setNombre(String nombre) {	this.nombre = nombre;	}
	
	
}
