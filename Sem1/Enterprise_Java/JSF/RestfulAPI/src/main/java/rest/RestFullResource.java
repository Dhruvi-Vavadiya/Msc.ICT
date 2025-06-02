/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/GenericResource.java to edit this template
 */
package rest;

import ejb.DataBeanaApiLocal;
import entity.Bookmaster;
import java.util.Collection;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Produces;
import javax.ws.rs.Consumes;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.enterprise.context.RequestScoped;
import javax.ws.rs.core.MediaType;
import javax.ejb.EJB;
import javax.ws.rs.DELETE;
import javax.ws.rs.POST;
import javax.ws.rs.PathParam;
/**
 * REST Web Service
 *
 * @author Planet
 */
@Path("restfull")
@RequestScoped
public class RestFullResource {

    @EJB DataBeanaApiLocal dbl;
    
    public RestFullResource() {
    }

    @GET
    @Produces("application/json")
    public Collection<Bookmaster> getAllBooks() {
        return dbl.getAllBooks();
    }

    @POST
    @Path("addbook/{bname}/{aname}/{pname}/{synopsis}")
    public void addBook(@PathParam("bname") String bname,@PathParam("aname") String aname,@PathParam("pname") String pname,@PathParam("synopsis") String synopsis) {
      dbl.addBook(bname, aname, pname, synopsis);
    }

    @PUT
    @Path("updatebook/{bid}/{bname}/{aname}/{pname}/{synopsis}")
    public void updateBook(@PathParam("bid") Integer bid,@PathParam("bname") String bname,@PathParam("aname") String aname,@PathParam("pname") String pname,@PathParam("synopsis") String synopsis) {
      dbl.updateBook(bid, bname, aname, pname, synopsis);
    }

    @DELETE
    @Path("removebook/{bid}")
    public void removeBook(@PathParam("bid") Integer bid) {
        dbl.removeBook(bid);
    }
//
//    
//    public Collection<Bookmaster> findBooksByPublisher(String pname) {
//         
//    }
}
