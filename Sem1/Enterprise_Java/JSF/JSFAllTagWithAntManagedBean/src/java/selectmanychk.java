/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

/**
 *
 * @author Planet
 */
@Named(value = "selectmanychk")
@RequestScoped
public class selectmanychk {

    //selectitem
    private ArrayList<String> cou;

    public ArrayList<String> getCou() {
        return cou;
    }

    public void setCou(ArrayList<String> cou) {
        this.cou = cou;
    }
     
    //selectitems
    
    Map<String,String> items;

    public Map<String, String> getItems() {
        return items;
    }

    public void setItems(Map<String, String> items) {
        this.items = items;
    }
    
    public selectmanychk(){ //constrctor
        items=new HashMap<>();
        items.put("c", "proc c");
        items.put("c+", "proc c+");
        items.put("java", "proc java");
        items.put("c#", "proc c#");
        
    }
    
    
    
    
    
}
