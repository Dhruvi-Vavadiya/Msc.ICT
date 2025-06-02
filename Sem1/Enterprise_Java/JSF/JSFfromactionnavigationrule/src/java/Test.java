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
@Named(value = "test")
@RequestScoped
public class Test {

    /**
     * Creates a new instance of Test
     */
    public Test() {
    }
    public String displayTestPage() {
		return "success";
	}
 
	public String displayWelcomePage() {
		return "success";
	}
    
}
