package com.example.examenactivities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import org.w3c.dom.Text;

public class Confirmacion extends AppCompatActivity {

    //Variables que enlazaremos con los elementos gráficos de la ventana
    private TextView trabajador, tlf, password, sex;

    //Método constructor de la tercera ventana
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //Con setContentView establecemos todos los elementos gráficos de la ventana
        setContentView(R.layout.activity_confirmacion);

        //Asociamos nuestras variables al elemento gráfico que corresponde
        trabajador = (TextView)findViewById(R.id.lTrabajador);
        tlf = (TextView)findViewById(R.id.lTlf);
        password = (TextView)findViewById(R.id.lPassword);
        sex = (TextView)findViewById(R.id.tSexo);

        //Cogemos toda la información extra pasada desde la ventana anterior (los parámetros)
        Bundle bundle = getIntent().getExtras();

        /*Guardamos en variables de tipo cadena el valor asociado a cada una de las claves de los parámetros enviados
        * Además seteamos los TextView concatenando el contenido de los visores de texto con los valores que hemos guardado*/
        String nom = bundle.getString("nombre");
        String ape = bundle.getString("apellidos");
        trabajador.setText(trabajador.getText().toString() + nom + " " + ape);
        String tel = bundle.getString("telefono");
        tlf.setText(tlf.getText().toString() + tel);
        String pas = bundle.getString("contrasenia");
        password.setText(password.getText().toString() + pas);
        String sexo = bundle.getString("sexo");
        sex.setText(sex.getText().toString() + sexo);
    }

    //Método que permite volver a la ventana inicial, se ejecuta al pulsar bInicio
    public void inicio(View view){
        //Creamos una nueva instancia de la clase MainActivity
        Intent i = new Intent(this, MainActivity.class);
        //Iniciamos la actividad de la ventana
        startActivity(i);
        //Cerramos la ventana actual
        finish();
    }

    //Método que permite volver a la ventana de registro, se ejecuta al pulsar bRegistro
    public void registro(View view){
        //Creamos una nueva instancia de la clase Registro
        Intent r = new Intent(this, Registro.class);
        //Iniciamos la actividad de la ventana
        startActivity(r);
        //Cerramos la ventana actual
        finish();
    }

    //Método que permite cerrar la aplicación, se ejecuta al pulsar bSalir
    public void salir(View view){
        //Cerramos la ventana actual
        finish();
        //Finalizamos la ejecución del programa
        System.exit(0);
    }
}