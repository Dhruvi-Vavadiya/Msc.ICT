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
@Named(value = "dateconvertoer")
@RequestScoped
public class dateconvertoer {

    
    private Date dob;

    public void setDob(Date dob) {
        this.dob = dob;
    }

    public Date getDob() {
        return dob;
    }
    
    public String display(){
        if(dob==null|| dob.equals("")){
            return "not done";
        }else{
            return "done";
        }
    }
    
}
