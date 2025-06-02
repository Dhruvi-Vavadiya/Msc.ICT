/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
package bean;

import client.BookClient;
import entity.Bookmaster;
import java.util.ArrayList;
import java.util.Collection;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import javax.ws.rs.core.GenericType;

import javax.ws.rs.core.Response;

/**
 *
 * @author Planet
 */
@Named(value = "tableManagedBean")
@RequestScoped
public class tableManagedBean {
    
    BookClient bc;
    Response rs;
    Collection<Bookmaster> books;
    GenericType<Collection<Bookmaster>> gbooks;
  
    public tableManagedBean() {
        bc = new BookClient();
        books = new ArrayList<>();
        gbooks = new GenericType<Collection<Bookmaster>>(){};
    }

    public Collection<Bookmaster> getBooks() {
        rs = bc.getAllBooks(Response.class);
        books = rs.readEntity(gbooks);
        return books;
    }

    public void setBooks(Collection<Bookmaster> books) {
        this.books = books;
    }
    
    
}
