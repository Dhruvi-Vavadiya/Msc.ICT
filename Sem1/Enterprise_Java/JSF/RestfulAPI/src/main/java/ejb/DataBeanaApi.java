/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/J2EE/EJB30/StatelessEjbClass.java to edit this template
 */
package ejb;

import entity.Bookmaster;
import java.util.Collection;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 *
 * @author Planet
 */
@Stateless
public class DataBeanaApi implements DataBeanaApiLocal {

     @PersistenceContext(name = "mypu")
    EntityManager em;
    

    @Override
    public Collection<Bookmaster> getAllBooks() {
        Collection<Bookmaster> books = em.createNamedQuery("Bookmaster.findAll").getResultList();
        return books;

    }

    @Override
    public void addBook(String bname, String aname, String pname, String synopsis) {
        Bookmaster b = new Bookmaster();
        b.setBookName(bname);
        b.setAuthor(aname);
        b.setPublisherName(pname);
        b.setSynopsis(synopsis);

        em.persist(b);
    }

    @Override
    public void updateBook(Integer bid, String bname, String aname, String pname, String synopsis) {
        Bookmaster b =(Bookmaster) em.find(Bookmaster.class, bid);
       b.setBookName(bname);
       b.setAuthor(aname);
       b.setPublisherName(pname);
       b.setSynopsis(synopsis);
       
       em.merge(b);
    }

    @Override
    public void removeBook(Integer bid) {
        Bookmaster b = em.find(Bookmaster.class, bid);
    
     em.remove(b);
    }

    @Override
    public Collection<Bookmaster> findBooksByPublisher(String pname) {
         Collection<Bookmaster> books =  em.createNamedQuery("Bookmaster.findByPublisherName")
                                     .setParameter("publisherName", pname)
                                     .getResultList();
    
    return books;
    }
}
