/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
package chillyfacts;

import javax.inject.Named;
//import javax.inject.Named;
import java.util.*;
import java.sql.*;
//import javax.enterprise.context.RequestScoped;
import javax.enterprise.context.RequestScoped;
import javax.faces.context.FacesContext;

/**
 *
 * @author Planet
 */
@Named(value = "category")
@RequestScoped
public class Category {

 
    private String category_name;
    private String get_all_category;
    
    private String s1_no;

   
    

    public void setS1_no(String s1_no) {
        this.s1_no = s1_no;
    }

    public String getS1_no() {
        return s1_no;
    }

    public void setCategory_name(String category_name) {
        this.category_name = category_name;
    }

    public String getCategory_name() {
        return category_name;
    }

    public ArrayList<Category> getGet_all_category() {
        ArrayList<Category> listofCate = new ArrayList<Category>();
        try {
            Connection conn = null;
            DB_connection obj_conn = new DB_connection();
            conn = obj_conn.get_connection();

            Statement st = conn.createStatement();

            ResultSet rs = st.executeQuery("SELECT * FROM `category`");
            while (rs.next()) {
                Category obj = new Category();
                obj.setS1_no(rs.getString("cnm"));
                obj.setCategory_name(rs.getString("s1_no"));

                listofCate.add(obj);

            }
        } catch (Exception e) {
            System.err.println(e);
        }
        return listofCate;
    }

    public void add_Cate() {

        try {
            Connection conn = null;
            DB_connection obj_conn = new DB_connection();
            conn = obj_conn.get_connection();

            PreparedStatement pstmt = conn.prepareStatement("insert into category(cnm) VALUES ('" + category_name + "')");

            pstmt.executeUpdate();

        } catch (Exception e) {
            System.err.println(e);
        }

    }

//    public String edit_category(){
//        FacesContext fc = FacesContext.getCurrentInstance();
//        Map<String,String> params = fc.getExternalContext().getRequestParameterMap();
//        String field_s1_no = params.get("action");
//        try {
//             Connection conn = null;
//            DB_connection obj_conn = new DB_connection();
//            conn = obj_conn.get_connection();
//
//            Statement st = conn.createStatement();
//
//            ResultSet rs = st.executeQuery("select * from category where s1_no="+s1_no);
//            
//        } catch (Exception e) {
//        }
//  
//    }
    /**
     * Creates a new instance of Category
     */
    public Category() {
    }

}