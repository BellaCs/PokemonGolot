package android.app.pokemongolot.globals;

import android.content.Context;
import android.content.SharedPreferences;

public class SharedPreferencesEditor {

    SharedPreferences.Editor editor;
    Context context;

    public SharedPreferencesEditor(String fileKey , Context c)
    {
        this.context = c;
        this.editor = c.getSharedPreferences(
                fileKey , Context.MODE_PRIVATE
        ).edit();
    }

    public void safeString(String key, String value){
        editor.putString(key , value);
        editor.apply();
    }

}
