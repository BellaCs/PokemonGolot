package android.app.pokemongolot.requests.Posts;

import android.app.pokemongolot.requests.FormPost;

import com.fasterxml.jackson.databind.ObjectMapper;

import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class LoginPost {
    public Map<String, Object> post_login(String user, String password)
    {
        ExecutorService thread_pool = Executors.newCachedThreadPool();

        try {
            // Headers
            Map<String, String> headers = new HashMap<>();
            FormPost loginPost = new FormPost("https://172.24.4.221:7292/user/authenticate", "utf-8", headers);
            // Add form field
            loginPost.addFormField("user_name", user);
            loginPost.addFormField("password", password);
            // Result
            Future<String> response = thread_pool.submit(loginPost::finish);

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
