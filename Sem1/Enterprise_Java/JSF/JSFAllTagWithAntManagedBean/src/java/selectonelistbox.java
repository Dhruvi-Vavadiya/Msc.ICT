/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
import java.util.*;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Planet
 */
@Named(value = "selectonelistbox")
@RequestScoped
public class selectonelistbox {

    /**
     * Creates a new instance of selectonelistbox
     */
    public selectonelistbox() {
    }
    
//    //one item
    private String course;

    public String getCourse() {
        return course;
    }

    public void setCourse(String course) {
        this.course = course;
    }
    
    
    //many items
    
    private ArrayList<String> cous;

    public ArrayList<String> getCous() {
        return cous;
    }

    public void setCous(ArrayList<String> cous) {
        this.cous = cous;
    }
    
}
