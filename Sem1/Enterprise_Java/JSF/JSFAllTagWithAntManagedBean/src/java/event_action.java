/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
import javax.faces.event.*;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Planet
 */
@Named(value = "event_action")
@RequestScoped
public class event_action {

    /**
     * Creates a new instance of event_action
     */
    public void Proc(ActionEvent ae){
        System.out.println("get id using maanged beans ::"+ae.getComponent().getId());
    }
    
}
