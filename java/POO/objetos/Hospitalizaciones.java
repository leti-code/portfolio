package Portfolio;

import java.util.Scanner;

public class Hospitalizaciones implements Hospitalizable {
	protected int dia, mes, anio, codigo;
	protected Asegurados asegurado;
	protected Medicos medico;
	protected Hospital hospital;
	private static int numHosp = 0;
	protected boolean alta;
	private Scanner t;
	
	public Hospitalizaciones() {
		t = new Scanner(System.in);
		cambiarFecha();
		asegurado = new Asegurados();
		medico = new Medicos();
		hospital = new Hospital();
		numHosp++;
		codigo = numHosp;
		alta = false;
	}
	
	public Hospitalizaciones(Asegurados as, Medicos med, Hospital hos) {
		t = new Scanner(System.in);
		cambiarFecha();
		asegurado = as;
		medico = med;
		hospital = hos;
		numHosp++;
		codigo = numHosp;
		alta = false;
	}
	
	public void imprimir() {
		System.out.println("*****Datos de la hospitalizaci�n******");
		System.out.println("C�digo: " + codigo);
		System.out.println("Fecha: " + dia+ "-" + mes + "-" + anio);
		asegurado.imprimir();
		medico.imprimir();
		hospital.imprimir();
	}
	
	public void cambiarFecha() {
		int d, m,a;
		System.out.println("Introduzca el a�o");
		a = t.nextInt();
		while (a < 0)
		{
			System.out.println("No puede introducir un a�o negativo. Int�ntelo de nuevo");
			a = t.nextInt();
		}
		anio = a;
		System.out.println("Introduzca el mes");
		m = t.nextInt();
		while (m < 1 || m > 12)
		{
			System.out.println("No ha introducido un mes v�lido. Int�ntelo de nuevo");
			m = t.nextInt();
		}
		mes = m;
		System.out.println("Introduzca el d�a");
		d = t.nextInt();
		switch (mes) {
		case 1,3,5,7,8,10,12:
			while (d < 1 || d > 31)
			{
				System.out.println("No ha introducido un d�a v�lido. Int�ntelo de nuevo");
				d = t.nextInt();
			}
		break;
		case 4,6,9,11:
			while (d < 1 || d > 30)
			{
				System.out.println("No ha introducido un d�a v�lido. Int�ntelo de nuevo");
				d = t.nextInt();
			}
		break;
		case 2:
			while (d < 1 || d > 28)
			{
				System.out.println("No ha introducido un d�a v�lido. Int�ntelo de nuevo");
				d = t.nextInt();
			}
			break;
			default:
				System.out.println("Error");
		}
		dia = d;
	}

	
	@Override
	public boolean getEstado() {
		return alta;
	}

	@Override
	public void darAlta() {
		if (getEstado())
			System.out.println("Ya se hab�a dado el alta");
		else {
			alta = true;
			System.out.println("Procedemos a dar de alta");}
		
	}

	
}
