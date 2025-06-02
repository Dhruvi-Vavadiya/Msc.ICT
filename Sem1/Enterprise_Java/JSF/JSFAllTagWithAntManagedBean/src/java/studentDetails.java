/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.enterprise.context.SessionScoped;
import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author Planet
 */
@Named(value = "studentDetails")
@SessionScoped
public class studentDetails implements Serializable {

    ArrayList<student> a1;
    public ArrayList<student> fetchdata(){
        a1=new ArrayList<>();
        
        student s1=new student();
        s1.setRno("1");
        s1.setName("dhruvi");
        a1.add(s1);

        student s2=new student();
        s2.setRno("2");
        s2.setName("nency");
        a1.add(s2);
        
        return a1;
        
    }
    
    
    
}
