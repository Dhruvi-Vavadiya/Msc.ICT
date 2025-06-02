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
@Named(value = "inSecret")
@RequestScoped
public class inSecret {

    /**
     * Creates a new instance of inSecret
     */
    public inSecret() {
    }
    
    private String pwd;

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }
    
    public String displaypwd(){
        return pwd;
    }
    
}
