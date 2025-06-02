/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package chillyfacts;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author Planet
 */
public class DB_connection {
    public static void main(String[] args) {
        DB_connection obj=new DB_connection();
        
        System.err.println(obj.get_connection());
    }
    public Connection get_connection(){
        Connection con=null;
            
        try {
           Class.forName("com.mysql.jdbc.Driver");
            con = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/dhruvi", "root", "dhruvi");
            System.out.println("Class forname line Connection establish ");
        } catch (Exception e) {
            System.out.println(e);
        }
        
        return con;
    }
}
