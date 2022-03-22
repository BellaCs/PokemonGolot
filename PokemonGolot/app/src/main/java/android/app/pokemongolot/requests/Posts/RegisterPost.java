package android.app.pokemongolot.requests.Posts;

import android.app.pokemongolot.requests.FormPost;

import com.fasterxml.jackson.databind.ObjectMapper;

import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class RegisterPost {
    public Map<String, Object> post_register(String user, String password, String name, String dateBirth, String email, String url)
    {
        ExecutorService thread_pool = Executors.newCachedThreadPool();

        try {
            // Headers
            Map<String, String> headers = new HashMap<>();
            FormPost registerPost = new FormPost(url, "utf-8", headers);
            // Add form field
            registerPost.addFormField("user_name", user);
            registerPost.addFormField("password", password);
            registerPost.addFormField("name", name);
            //registerPost.addFormField("repeatPassword", repeatPassword);
            //registerPost.addFormField("dateBirth", dateBirth);
            registerPost.addFormField("email", email);

            // Result
            Future<String> response = thread_pool.submit(registerPost::finish);

            while (!response.isDone()){
                System.out.println("Waiting...");
            }

            Map<String, Object> map = new ObjectMapper().readValue(response.get(), HashMap.class);

            thread_pool.shutdown();

            return map;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
}
