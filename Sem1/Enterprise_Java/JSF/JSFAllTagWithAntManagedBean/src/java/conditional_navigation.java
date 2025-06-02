/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;
import javax.faces.bean.ManagedProperty;

/**
 *
 * @author Planet
 */
@Named(value = "conditional_navigation")
@RequestScoped
public class conditional_navigation {
    @ManagedProperty(value="#{param.pageId}")

    //first
    
    private boolean admin=true;

    public boolean isAdmin() {
        return admin;
    }

    public void setAdmin(boolean admin) {
        this.admin = admin;
    }
    
    private int type=2;

    public int getType() {
        return type;
    }

    public void setType(int type) {
        this.type = type;
    }
    
    //second
    
    private String pageId;

    public void setPageId(String pageId) {
        this.pageId = pageId;
    }

    public String getPageId() {
        return pageId;
    }
    
    public String displayPage(){
        if(pageId == null){
            return "conditional_navigation";
        }
        
        if(pageId.equals("inHidden")){
            return "inHidden";
        }else if(pageId.equals("cmdbtnjsf")){
            return "cmdbtnjsf";
        }else{
            return "conditional_navigation";
        }
    }
    
}
