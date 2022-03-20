package android.app.pokemongolot;

import android.app.pokemongolot.globals.SharedPreferencesEditor;
import android.app.pokemongolot.requests.Posts.RegisterPost;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Map;

public class RegisterActivity extends AppCompatActivity {
    EditText username;
    EditText password;
    EditText name;
    EditText repeatPassword;
    EditText dateBirth;
    EditText email;
    SharedPreferencesEditor tokenPreferencesEditor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);
        tokenPreferencesEditor = new SharedPreferencesEditor(getString(R.string.token_file_key), getApplicationContext());

    }
    public void register(View view) {
        username = findViewById(R.id.usernameInsert);
        //name = findViewById(R.id.nameInsert);
        password = findViewById(R.id.passwordInsert);
        //repeatPassword = findViewById(R.id.repeatpasswordInsert);
        //dateBirth = findViewById(R.id.birthdateInsert);
        email = findViewById(R.id.emailInsert);

        String usernameS = username.getText().toString(),
                passwordS = password.getText().toString(),
                //nameS = name.getText().toString(),
                //repeatPasswordS = repeatPassword.getText().toString(),
                //dateBirthS = dateBirth.getText().toString(),
                emailS = email.getText().toString();


        RegisterPost request = new RegisterPost();

        Map<String, Object> map = request.post_register(usernameS, passwordS, "CompleteName", "30/10/2001", emailS, R.string.server_base_url + "/user/register/player");
        System.out.println(map);

        if(map != null){
            tokenPreferencesEditor.safeString(getString(R.string.token_key), (String) map.get("token"));

        }
    }
}
