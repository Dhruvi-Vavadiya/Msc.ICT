/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Planet
 */
@Named(value = "jsf_ajax_inputtext")
@RequestScoped
public class jsf_ajax_inputtext {

    
    
    private String name;

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
    
    
    public String getSay_hello_ajax() {
        if(name==null || name.equals("")){
            return "plz enter name";
        }else{
            return "hello ajax ::"+name;
        }
    }
    
    
    
   
    
}
