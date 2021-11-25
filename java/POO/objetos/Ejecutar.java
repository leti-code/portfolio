package Portfolio;

public class Ejecutar {

	public static void main(String[] args) {
		Asegurados as = new Asegurados("Pepe", "913334445", "Calle Inventada 2");
		Medicos med = new Medicos();
		Hospital hos = new Hospital();
		Hospitalizable h1 = new Hospitalizaciones(as, med, hos);
		h1.imprimir();

		Asegurados asAnonimo = new Asegurados() {
			public void imprimir() {
				System.out.println("Datos del asegurado: ");
				System.out.println("N�mero de expediente: " + super.getNexp());
				System.out.println("Nombre: " + super.getNombre());
				//System.out.println(categorias.toString());
				/*No podemos acceder desde el main a los datos de la categor�a porque es una clase interna
				 * a la que s�lo se puede acceder desde Asegurados.
				 * En caso de que su visibilidad fuera otra podr�amos imprimir los datos de la categor�a 
				 * tal y como aparece en el comentario de arriba.*/
			}
			
		};
		
		Personas medPersona = new Medicos();
	}

}
