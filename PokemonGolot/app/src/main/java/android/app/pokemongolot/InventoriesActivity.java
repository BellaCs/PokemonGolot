package android.app.pokemongolot;
import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.view.View;

public class InventoriesActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_inventories_pokemon);

        // 1 - Show number of pokemons user's have
        // id → pokemonUnits


        //  2 - Show all user's pokemons
        // PC - Number
        // Image → Generate button for acces to pokemon info
        // Name
    }

    public void accessToInventoriesPokemon(View view) {
        Intent intent = new Intent(this, InventoriesPokemonActivity.class);
        startActivity(intent);
    }

    public void accessToPokedex(View view) {
        Intent intent = new Intent(this, PokedexActivity.class);
        startActivity(intent);
    }

}