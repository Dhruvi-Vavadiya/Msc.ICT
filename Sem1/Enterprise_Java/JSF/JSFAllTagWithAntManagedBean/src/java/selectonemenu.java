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
@Named(value = "selectonemenu")
@RequestScoped
public class selectonemenu {

    /**
     * Creates a new instance of selectonemenu
     */
    //one menu like dropdown
    public selectonemenu() {
    }
    
    private String course;

    public String getCourse() {
        return course;
    }

    public void setCourse(String course) {
        this.course = course;
    }
    
    
    
    //many menu
    
    private ArrayList<String> coursemany;

    public ArrayList<String> getCoursemany() {
        return coursemany;
    }

    public void setCoursemany(ArrayList<String> coursemany) {
        this.coursemany = coursemany;
    }
    
    
    
    
    
    
}
