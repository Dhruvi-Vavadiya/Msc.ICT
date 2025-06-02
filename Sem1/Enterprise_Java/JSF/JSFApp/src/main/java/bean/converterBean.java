/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
package bean;

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Planet
 */
@Named(value = "converterBean")
@RequestScoped
public class converterBean {
    
    
  String somename="ABC-Rahul";

    
    public converterBean() {
    }
      public String getSomename() {
        return somename;
    }

    public void setSomename(String somename) {
        this.somename = somename;
    }
}
