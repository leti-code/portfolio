package com.example.examenactivities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    //Método constructor de la primera ventana
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //Con setContentView establecemos todos los elementos gráficos de la ventana
        setContentView(R.layout.activity_main);
    }

    //Método que se activa al pulsar el botón de la primera ventana bEntrar
    public void entrar(View view){
        //Crea una nueva instancia de la segunda ventana de la clase Registro
        Intent i = new Intent(this, Registro.class);
        //Inicia la actividad del Activity
        startActivity(i);
        //Cierra esta ventana
        finish();
    }
}