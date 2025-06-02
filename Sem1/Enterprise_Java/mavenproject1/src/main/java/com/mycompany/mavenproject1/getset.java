/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.mavenproject1;



class myEmp{
   private int id;
   private String nm;
   
   public void setName(String n){
       nm=n;
   }
   public String getName(){
       return nm;
   }
   public void setId(int i){
       id=i;
   }
   public int getId(){
       return id;
   }
}
public class getset {
    
     public static void main(String[] args){
         myEmp e=new myEmp();
//         e.id=4;
//         e.nm="djhru";
        e.setName("dhruvi");
        System.out.println(e.getName());
        e.setId(20012004);
        System.out.println(e.getId());
     }
}
