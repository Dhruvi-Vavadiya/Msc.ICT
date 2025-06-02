package com.mycompany.jsfapp.resources;

import ejb.DataSessionBeanLocal;
import entity.Bookmaster;
import java.util.Collection;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.Response;
import javax.ejb.*;

/**
 *
 * @author 
 */
@Path("rest")
public class JakartaEE8Resource {
       @EJB DataSessionBeanLocal dbl;
    
    @GET
   @Produces("application/json")
    public Collection<Bookmaster> getAllBooks() {
       return dbl.getAllBooks();
    }
}
