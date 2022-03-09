package android.app.pokemongolot;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.view.View;
import android.view.View.OnTouchListener;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    public void accessToWelcomeAccount(View view) {
        Intent intent = new Intent(this, WelcomeAccount.class);
        startActivity(intent);
    }
}