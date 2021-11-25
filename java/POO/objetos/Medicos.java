package Portfolio;

import java.util.Scanner;

public class Medicos extends Personas {
	protected String especialidad;
	protected Companias compania;
	private Scanner teclado;
	
	public Medicos() {
		teclado = new Scanner(System.in);
		System.out.println("Introduce la especialidad");
		especialidad = teclado.next();
		compania = new Companias();
	}
	
	public Medicos(String nombre, String tlf, String especialidad, String nomComp, String tlfComp){
		super(nombre, tlf);
		this.especialidad = especialidad;
		compania = new Companias(nomComp, tlfComp);
	}

	public void imprimir() {
		super.imprimir();
		System.out.println("*****Datos del medico*****");
		System.out.println("Especialidad: " + especialidad);
		compania.imprimir();
	}
	@Override
	public String obtenerTipo() {	return "medico";}

}
