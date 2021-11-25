package Portfolio;

import java.util.Scanner;

public abstract class Personas {
	protected String telefono, nombre;
	protected int nexp;
	private static int numPersonas = 0;
	private Scanner tec;
	
	public Personas() {
		tec = new Scanner(System.in);
		System.out.println("Creando una persona...");
		System.out.println("Introduce el nombre");
		setNombre(tec.next());
		System.out.println("Introduce el tel�fono");
		setTelefono(tec.next());
		numPersonas++;
		nexp = numPersonas;
	}
	
	public Personas(String tel, String nom) {
		System.out.println("Creando una persona...");
		tec = new Scanner(System.in);
		setNombre(nom);
		setTelefono(tel);
		numPersonas++;
		nexp = numPersonas;
	}
	
	public abstract String obtenerTipo();
	
	public void imprimir() {
		toString();
		System.out.println("Tipo: " + obtenerTipo());
	}
	
	@Override
	public String toString() {
		return "Datos de la persona: \n Telefono:" + telefono + "\n N�mero de expediente: " + nexp + "\n Nombre:" + nombre;
	}
	public String getTelefono() {	return telefono;}
	public void setTelefono(String telefono) {	this.telefono = telefono;}
	public String getNombre() {	return nombre;}
	public void setNombre(String nombre) {	this.nombre = nombre;}
	public int getNexp() {return nexp;}

}
