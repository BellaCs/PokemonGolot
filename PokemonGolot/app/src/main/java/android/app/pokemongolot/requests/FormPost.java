package android.app.pokemongolot.requests;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.Map;

public class FormPost {
    private final HttpURLConnection httpConn;
    private final Map<String, Object> queryParams;
    private final String charset;

    public FormPost(String requestURL, String charset, Map<String, String> headers, Map<String, Object> queryParams) throws IOException {
        this.charset = charset;
        if (queryParams == null) {
            this.queryParams = new HashMap<>();
        } else {
            this.queryParams = queryParams;
        }
        URL url = new URL(requestURL);
        httpConn = (HttpURLConnection) url.openConnection();
        httpConn.setRequestMethod("POST");
        httpConn.setUseCaches(false);
        httpConn.setDoOutput(true);    // indicates POST method
        httpConn.setDoInput(true);
        httpConn.setRequestProperty("Content-Type", "application/x-www-form-urlencoded");
        if (headers != null && headers.size() > 0) {
            for (String key : headers.keySet()) {
                String value = headers.get(key);
                httpConn.setRequestProperty(key, value);
            }
        }
    }
    public FormPost(String requestURL, String charset, Map<String, String> headers) throws IOException {
        this(requestURL, charset, headers, null);
    }

    public FormPost(String requestURL, String charset) throws IOException {
        this(requestURL, charset, null, null);
    }

    /**
     * Adds a form field to the request
     *
     * @param name  field name
     * @param value field value
     */
    public void addFormField(String name, Object value) {
        queryParams.put(name, value);
    }

    /**
     * Adds a header to the request
     *
     * @param key field key
     * @param value field value
     */
    public void addHeader(String key, String value) {
        httpConn.setRequestProperty(key, value);
    }

    /**
     * Convert the request fields to a byte array
     *
     * @param params parameters to set
     * @return result
     */
    private byte[] getParamsByte(Map<String, Object> params) {
        byte[] result = null;
        StringBuilder postData = new StringBuilder();
        for (Map.Entry<String, Object> param : params.entrySet()) {
            if (postData.length() != 0) {
                postData.append('&');
            }
            postData.append(this.encodeParam(param.getKey()));
            postData.append('=');
            postData.append(this.encodeParam(String.valueOf(param.getValue())));
        }
        try {
            result = postData.toString().getBytes("UTF-8");
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }
        return result;
    }

    /**
     * URL-encoding keys and values
     *
     * @param data data to encode
     * @return encoded data
     */
    private String encodeParam(String data) {
        String result = "";
        try {
            result = URLEncoder.encode(data, "UTF-8");
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }
        return result;
    }

    /**
     * Completes the request and receives response from the server.
     *
     * @return String as response in case the server returned
     * status OK, otherwise an exception is thrown.
     */

    public String finish() throws IOException {
        String response = "";
        byte[] postDataBytes = this.getParamsByte(queryParams);
        httpConn.getOutputStream().write(postDataBytes);
        // Check the http status
        int status = httpConn.getResponseCode();
        if (status == HttpURLConnection.HTTP_OK) {
            ByteArrayOutputStream result = new ByteArrayOutputStream();
            byte[] buffer = new byte[1024];
            int length;
            while ((length = httpConn.getInputStream().read(buffer)) != -1) {
                result.write(buffer, 0, length);
            }
            response = result.toString(this.charset);
            httpConn.disconnect();
        } else {
            throw new IOException("Server returned non-OK status: " + status);
        }
        return response;
    }
}