package Portfolio;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.*;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;


import javax.swing.*;

public class EditorTexto {
	protected JFrame v;
	protected JPanel c;
	protected JTextArea ed;
	protected JButton abrir, guardar, salir;
	protected JMenuBar barraMenu;
	protected JMenu menuArchivo, menuColores, menuFuentes;
	protected JMenuItem iCerrar, iAbrir, iGuardar, iRojo, iVerde, iAzul, iNegrita, iCursiva, iNormal;
	protected JSeparator separador;
	protected File f;
	
	
	public EditorTexto() {
		crearVentana();
		crearContenedor();
		crearComponentes();
		crearMenu();
		controlarEventos();
		
		v.setVisible(true);
		
	}
	
	private void controlarEventos() {
		accionSalir as = new accionSalir();
		salir.addActionListener(as);
		iCerrar.addActionListener(as);
		cambiarColor cc = new cambiarColor();
		iRojo.addActionListener(cc);
		iVerde.addActionListener(cc);
		iAzul.addActionListener(cc);
		cambiarFuente cf = new cambiarFuente();
		iNegrita.addActionListener(cf);
		iCursiva.addActionListener(cf);
		iNormal.addActionListener(cf);
		
		accionAbrir ab = new accionAbrir();
		abrir.addActionListener(ab);
		iAbrir.addActionListener(ab);
		accionGuardar ag = new accionGuardar();
		guardar.addActionListener(ag);
		iGuardar.addActionListener(ag);
	}
	
	private class cambiarColor implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			if(e.getSource() == iRojo) {
				c.setBackground(Color.red);
				ed.setForeground(Color.red);
			}else if(e.getSource() == iVerde) {
				c.setBackground(Color.green);
				ed.setForeground(Color.green);
			}else if(e.getSource() == iAzul) {
				c.setBackground(Color.blue);
				ed.setForeground(Color.blue);
			}
		}
		
	}
	
	private class cambiarFuente implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			int estilo = Font.PLAIN;
			if(e.getSource() == iNegrita)
				estilo = Font.BOLD;
			else if(e.getSource() == iCursiva)
				estilo = Font.ITALIC;
			else if(e.getSource() == iNormal)
				estilo = Font.PLAIN;
			
			ed.setFont(new Font(ed.getFont().getFamily(), estilo, ed.getFont().getSize()));

		}
		
	}
	
	
	private class accionGuardar implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			try{
				if (f == null) {
					JFileChooser jf = new JFileChooser();
					jf.showDialog(null, "Abrir");
					f = jf.getSelectedFile();
				}
			
				
				FileWriter fw = new FileWriter(f.getAbsolutePath());
				BufferedWriter buff = new BufferedWriter(fw);
				buff.write(ed.getText());
				buff.close();
				
				JOptionPane.showMessageDialog(c, "Se ha guardado correctamente", "Guardado", JOptionPane.INFORMATION_MESSAGE);
				
				
			//}catch (FileNotFoundException fnf) {
				//System.out.println("No se encuentra el archivo");
			}catch(Exception ex) {
				System.out.println("Se ha producido un error");
			}
			
		}
		
	}
	
	private class accionAbrir implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			try{
			JFileChooser jf = new JFileChooser();
			jf.showDialog(null, "Abrir");
			f = jf.getSelectedFile();		
			String text = readFullDoc();
			
			ed.setText(text);
			}catch (Exception ex) {
				System.out.println("Se ha producido un error");
			}
		}
		
		
	}
	
	public String readFullDoc() {
		try{
		FileReader fr = new FileReader(f.getAbsolutePath());
		
		BufferedReader buff = new BufferedReader(fr);
		String text, line;
		text = null;
		while((line = buff.readLine()) != null) {
			if(text == null)
				text = line + '\n';
			else
				text = text + line + '\n';
		}
		return text;
		}catch (FileNotFoundException fnf) {
			System.out.println("No se encuentra el archivo");
			f = null;
			return null;
		}catch (Exception ex) {
			System.out.println("Se ha producido un error");
			
		}
		return null;
	}
	private class accionSalir implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			
			if((f != null &&(!readFullDoc().equals(ed.getText()))) || (f==null && (!ed.getText().equals(""))))
			{
				int n=JOptionPane.showConfirmDialog(c, "Ha realizado cambios no ha guardado.\n�Seguro que quieres salir?", "Alerta!", JOptionPane.YES_NO_OPTION);
				if(n== JOptionPane.YES_OPTION)
					System.exit(0);
			}else
				System.exit(0);
			
		}
		
	}
	
	private void crearMenu() {
		barraMenu = new JMenuBar();
		menuArchivo = new JMenu("Archivo");
		menuColores = new JMenu("Colores");
		barraMenu.add(menuArchivo);
		barraMenu.add(menuColores);
		
		iCerrar = new JMenuItem("Cerrar");
		iAbrir = new JMenuItem("Abrir archivo");
		iGuardar = new JMenuItem("Guardar archivo");
		menuArchivo.add(iCerrar);
		menuArchivo.add(iAbrir);
		menuArchivo.add(iGuardar);
		
		iRojo = new JMenuItem("Rojo");
		iVerde = new JMenuItem("Verde");
		iAzul = new JMenuItem("Azul");
		menuFuentes = new JMenu("Fuentes");
		menuColores.add(iRojo);
		menuColores.add(iVerde);
		menuColores.add(iAzul);
		
		separador = new JSeparator();
		menuColores.add(separador);
		
		menuColores.add(menuFuentes);
		
		iNegrita = new JMenuItem("Negrita");
		iCursiva = new JMenuItem("Cursiva");
		iNormal = new JMenuItem("Normal");
		menuFuentes.add(iNegrita);
		menuFuentes.add(iCursiva);
		menuFuentes.add(iNormal);
		
		v.setJMenuBar(barraMenu);

	}
	
	private void crearComponentes() {
		ed = new JTextArea();
		
		ed.setBounds(10, 10, 350, 350);
		c.add(ed);
		
		abrir = new JButton("Abrir");
		abrir.setBounds(145, 365, 65, 25);
		c.add(abrir);
		
		guardar = new JButton("Guardar");
		guardar.setBounds(220, 365, 85, 25);
		c.add(guardar);
		
		salir = new JButton("Salir");
		salir.setBounds(365, 185, 65, 25);
		c.add(salir);
	}
	
	private void crearContenedor() {
		c = new JPanel();
		c.setLayout(null);
		v.getContentPane().add(c);
	}
	private void crearVentana() {
		v = new JFrame();
		v.setTitle("Mi primer editor de texto");
		v.setBounds(250, 250, 450, 470);
		v.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	public static void main(String[] args) {
		EditorTexto editor = new EditorTexto();
	}
}
