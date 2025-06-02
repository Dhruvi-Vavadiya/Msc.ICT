/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.mavenproject1;

import java.sql.*;
import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Planet
 */
public class Mavenproject1 {
    Connection con;
    Mavenproject1() throws SQLException{
        
        try {
            Class.forName("com.mysql.jdbc.Driver");
            con=(Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/dhruvi","dhruvi","");
            System.out.println("Class forname line Connection establish ");
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Mavenproject1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void show() throws SQLException{
        String query="select * from emp";
        Statement stmt=con.createStatement();
        ResultSet rs=stmt.executeQuery(query);
        while(rs.next()){
            System.out.println(rs.getInt(1)+"\t"
                    +rs.getString(2)+"\t"
                    +rs.getString(3)+"\t"
                    +rs.getString(4)+"\t"
                    +rs.getInt(5));
        }
        
    }
    public void insert(){
//        String pinset=;
       
        try {
             PreparedStatement stmt = con.prepareCall("insert into emp values(?,?,?,?,?)");
            stmt.setInt(1,101);
            stmt.setString(2,"abc");
            stmt.setString(3,"abc");
            stmt.setString(4,"abc");
            stmt.setInt(5,8000);
            int i=stmt.executeUpdate();  
            System.out.println(i+" records inserted"); 
        } catch (SQLException ex) {
            Logger.getLogger(Mavenproject1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void update(){

        try {
            PreparedStatement stmt = con.prepareCall("update emp set fnm=? where id=?");
           
            stmt.setString(1,"janu");
             stmt.setInt(2,101);
            int i=stmt.executeUpdate();  
            System.out.println(i+" records update successfully.."); 
        } catch (SQLException ex) {
            Logger.getLogger(Mavenproject1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public void del(){

        try {
            PreparedStatement stmt = con.prepareCall("delete from emp where id=?");
           
//            stmt.setString(1,"janu");
             stmt.setInt(1,6);
            int i=stmt.executeUpdate();  
            System.out.println(i+" records Delete successfully.."); 
        } catch (SQLException ex) {
            Logger.getLogger(Mavenproject1.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    public static void main(String[] args) throws SQLException {
        Mavenproject1 conn=new Mavenproject1();
        
       
//        conn.insert();
//           conn.update();
//            conn.del();
        
         conn.show();
//        System.out.println("Hello World!");
    }
}
