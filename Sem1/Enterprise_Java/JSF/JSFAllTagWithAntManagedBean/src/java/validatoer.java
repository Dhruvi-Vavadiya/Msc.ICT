
import javax.faces.application.FacesMessage;
import javax.faces.component.UIComponent;
import javax.faces.context.FacesContext;
import javax.faces.validator.FacesValidator;
import javax.faces.validator.Validator;
import javax.faces.validator.ValidatorException;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Planet
 */
@FacesValidator(value = "mv")
public class validatoer  implements  Validator{

    @Override
    public void validate(FacesContext fc, UIComponent uic, Object o) throws ValidatorException {
        String s=(String)o;
        if(!s.contains("a")){
            FacesMessage fm=new FacesMessage();
            fm.setSummary("must contain A letter (FacesValidator error)");
            throw new ValidatorException(fm);
        }
    }
    
}
