/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import javax.faces.application.FacesMessage;
import javax.faces.component.UIComponent;
import javax.faces.context.FacesContext;
import javax.faces.validator.ValidatorException;

/**
 *
 * @author Planet
 */
@Named(value = "validatoercustom")
@RequestScoped
public class validatoercustom {

    public void chaeckA(FacesContext fc, UIComponent uic, Object o) {
        String s=(String)o;
        if(!s.contains("a")){
            FacesMessage fm=new FacesMessage();
            fm.setSummary("Must be contain A letter (Managed beans error)");
            throw new ValidatorException(fm);
        }
    }
    
}
