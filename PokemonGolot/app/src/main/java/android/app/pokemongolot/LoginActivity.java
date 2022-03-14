package android.app.pokemongolot;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText username;
    EditText password;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
    }


    public void onClick(View view) {
        Intent intent = new Intent(this, MapActivity.class);
        startActivity(intent);
    }

    public void logIn(View view) {
        username = findViewById(R.id.usernameloginInsert);
        password = findViewById(R.id.passwordloginInsert);
        //Intent intent = new Intent(this, MainActivity2.class);
        if(username.getText().toString().equals("admin") && password.getText().toString().equals("admin")) {
            //startActivity(intent);
            Toast.makeText(getApplicationContext(), "Hola",Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(getApplicationContext(), "Dades incorrectes",Toast.LENGTH_SHORT).show();
        }
    }
}