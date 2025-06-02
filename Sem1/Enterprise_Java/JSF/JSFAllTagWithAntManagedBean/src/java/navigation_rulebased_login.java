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
@Named(value = "navigation_rulebased_login")
@RequestScoped
public class navigation_rulebased_login {

    /**
     * Creates a new instance of navigation_rulebased_login
     */
    public navigation_rulebased_login() {
    }
    
    private String name;
    private String password;
    

    public void setName(String name) {
        this.name = name;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    

    public String getName() {
        return name;
    }

    public String getPassword() {
        return password;
    }
        
    public String checkLogin(){
        if(name.equals("dh") && password.equals("123")){
            return "wel";
        }else{
            return "fail";
        }
    }
    
    
}
