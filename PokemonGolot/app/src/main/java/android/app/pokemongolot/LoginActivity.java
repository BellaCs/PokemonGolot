package android.app.pokemongolot;

import androidx.appcompat.app.AppCompatActivity;

import android.app.pokemongolot.globals.SharedPreferencesEditor;
import android.app.pokemongolot.requests.Posts.LoginPost;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import java.util.Map;

public class LoginActivity extends AppCompatActivity {

    EditText username;
    EditText password;
    SharedPreferencesEditor tokenPreferencesEditor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        tokenPreferencesEditor = new SharedPreferencesEditor(getString(R.string.token_file_key), getApplicationContext());
    }

    public void logIn(View view) {
        username = findViewById(R.id.usernameloginInsert);
        password = findViewById(R.id.passwordloginInsert);

        String usernameS = username.getText().toString(),
                passwordS = password.getText().toString();

        LoginPost request = new LoginPost();

        Map<String, Object> map = request.post_login(usernameS, passwordS);

        if(map != null){
            tokenPreferencesEditor.safeString(getString(R.string.token_key), map.get("token").toString());

        }
    }
}