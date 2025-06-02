/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */

import javax.inject.Named;
import javax.enterprise.context.SessionScoped;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.*;
/**
 *
 * @author Planet
 */

//2nd page
@Named(value = "add_studentDetails")
@SessionScoped
public class Add_studentDetails implements Serializable {

  
//    public Add_studentDetails() {
//    }
    
    
    private String name;
    private String SClass;
    private String rno;
    private int age;
    
    private static final List<Add_student> Stud_list = 
            new ArrayList<Add_student>(Arrays.asList(
                    new Add_student("abc","mca","52",58),
                    new Add_student("wsdx","mca","47",47)));

    public List<Add_student> getStudents(){
		return Stud_list;
	}
 
	public String addStudent(){
		Stud_list.add(new 
				Add_student(name, SClass, rno, age));
		return null;
	}
    
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSClass() {
        return SClass;
    }

    public void setSClass(String SClass) {
        this.SClass = SClass;
    }

    public String getRno() {
        return rno;
    }

    public void setRno(String rno) {
        this.rno = rno;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
    
    
}
