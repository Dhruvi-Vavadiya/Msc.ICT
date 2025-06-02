/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

import javax.faces.event.*;
/**
 *
 * @author Planet
 */
public class event_valuechange implements ValueChangeListener{

    @Override
    public void processValueChange(ValueChangeEvent event) throws AbortProcessingException {
        System.err.println(event.getOldValue()+ "  "+event.getNewValue());
    }
    
}
