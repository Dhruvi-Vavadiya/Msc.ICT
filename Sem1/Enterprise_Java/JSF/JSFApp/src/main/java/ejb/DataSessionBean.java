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
public class DataSessionBean implements DataSessionBeanLocal {

    // Add business logic below. (Right-click in editor and choose
    // "Insert Code > Add Business Method")
     @PersistenceContext(name = "mypu")
    EntityManager em;

    @Override
    public Collection<Bookmaster> getAllBooks() {
       return em.createNamedQuery("Bookmaster.findAll").getResultList();
    }
     
     
}
