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
@Named(value = "selectbolchk")
@RequestScoped
public class selectbolchk {

    /**
     * Creates a new instance of selectbolchk
     */
    public selectbolchk() {
    }
    
    private String selectProperty;

    public String getSelectProperty() {
        return selectProperty;
    }

    public void setSelectProperty(String selectProperty) {
        this.selectProperty = selectProperty;
    }
    
    
    
}
