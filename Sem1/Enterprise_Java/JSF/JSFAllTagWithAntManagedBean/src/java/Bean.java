/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.faces.view.ViewScoped;
import java.io.Serializable;

import javax.faces.bean.ManagedBean;
//import javax.faces.bean.ViewScoped;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Planet
 */
@Named(value = "bean")
@ViewScoped
public class Bean implements Serializable {

    /**
     * Creates a new instance of NewJSFManagedBean
     */
    public Bean() {
    }
     private String name;
    private String message;
    private List<String> selectedOptions = new ArrayList<>();

    // Getters and setters
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public List<String> getSelectedOptions() {
        return selectedOptions;
    }

    public void setSelectedOptions(List<String> selectedOptions) {
        this.selectedOptions = selectedOptions;
    }

    // Action method
    public String submit() {
        // You can handle the form submission logic here
        return null; // Stay on the same page
    }
}
