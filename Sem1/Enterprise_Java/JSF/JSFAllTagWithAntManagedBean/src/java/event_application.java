/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

import javax.faces.application.Application;
import javax.faces.event.*;
/**
 *
 * @author Planet
 */
public class event_application implements  SystemEventListener{

    @Override
    public void processEvent(SystemEvent event) throws AbortProcessingException {
        if(event instanceof  PostConstructApplicationEvent){
            System.err.println("Post construct application event");
        }
        if(event instanceof  PreDestroyApplicationEvent){
            System.err.println("Pre destroy application event");
        }
    }

    @Override
    public boolean isListenerForSource(Object o) {
        return (o instanceof Application);
    }
    
}
