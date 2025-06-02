
import javax.faces.application.FacesMessage;
import javax.faces.component.UIComponent;
import javax.faces.context.FacesContext;
import javax.faces.convert.Converter;
import javax.faces.convert.FacesConverter;
import javax.faces.validator.ValidatorException;
import javax.validation.ValidationException;
import org.glassfish.soteria.identitystores.hash.PasswordHashCompare;
import org.glassfish.soteria.identitystores.hash.Pbkdf2PasswordHashImpl;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Planet
 */
@FacesConverter(value="convertoer")
public class convertoer implements Converter{
    
     Pbkdf2PasswordHashImpl pb;
  PasswordHashCompare phc;

    @Override
    public Object getAsObject(FacesContext fc, UIComponent uic, String string) {
        if(string.length()<5){
            FacesMessage fm=new FacesMessage();
            fm.setSummary("Your String less 5");
            throw new ValidatorException(fm);
        }else{
            pb=new Pbkdf2PasswordHashImpl();
            phc=new PasswordHashCompare();
            String enc = pb.generate(string.toCharArray());
            return enc;
//            return string.concat("!!!!");
        }
    }

    @Override
    public String getAsString(FacesContext fc, UIComponent uic, Object o) {
        return o.toString();
    }
    
}
