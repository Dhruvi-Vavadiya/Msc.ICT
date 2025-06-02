
import javax.faces.event.*;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Planet
 */
public class event_action1 implements ActionListener{

    @Override
    public void processAction(ActionEvent ae) throws AbortProcessingException {
            System.out.println("Get button id by java class ::"+ae.getComponent().getId());
    }
    
    
}
