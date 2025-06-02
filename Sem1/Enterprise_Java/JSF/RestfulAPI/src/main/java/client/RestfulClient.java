/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/JerseyClient.java to edit this template
 */
package client;

import javax.ws.rs.ClientErrorException;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.WebTarget;

/**
 * Jersey REST client generated for REST resource:RestFullResource
 * [restfull]<br>
 * USAGE:
 * <pre>
 *        RestfulClient client = new RestfulClient();
 *        Object response = client.XXX(...);
 *        // do whatever with response
 *        client.close();
 * </pre>
 *
 * @author Planet
 */
public class RestfulClient {

    private WebTarget webTarget;
    private Client client;
    private static final String BASE_URI = "http://localhost:8080/RestfulAPI/resources";

    public RestfulClient() {
        client = javax.ws.rs.client.ClientBuilder.newClient();
        webTarget = client.target(BASE_URI).path("restfull");
    }

    public <T> T getAllBooks(Class<T> responseType) throws ClientErrorException {
        WebTarget resource = webTarget;
        return resource.request(javax.ws.rs.core.MediaType.APPLICATION_JSON).get(responseType);
    }

    public void updateBook(String bid, String bname, String aname, String pname, String synopsis) throws ClientErrorException {
        webTarget.path(java.text.MessageFormat.format("updatebook/{0}/{1}/{2}/{3}/{4}", new Object[]{bid, bname, aname, pname, synopsis})).request().put(null);
    }

    public void addBook(String bname, String aname, String pname, String synopsis) throws ClientErrorException {
        webTarget.path(java.text.MessageFormat.format("addbook/{0}/{1}/{2}/{3}", new Object[]{bname, aname, pname, synopsis})).request().post(null);
    }

    public void removeBook(String bid) throws ClientErrorException {
        webTarget.path(java.text.MessageFormat.format("removebook/{0}", new Object[]{bid})).request().delete();
    }

    public void close() {
        client.close();
    }
    
}
