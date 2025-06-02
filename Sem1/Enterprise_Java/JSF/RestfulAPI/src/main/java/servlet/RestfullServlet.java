/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import client.*;
import ejb.*;
import entity.Bookmaster;
import java.util.*;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.ws.rs.core.GenericType;
import javax.ws.rs.core.Response;

/**
 *
 * using rest
 */
@WebServlet(name = "RestfullServlet", urlPatterns = {"/RestfullServlet"})
public class RestfullServlet extends HttpServlet {

    RestfulClient rfc;
    Response rs;
    
    Collection <Bookmaster> bm;
    GenericType<Collection<Bookmaster>> gbm;
    
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet RestfullServlet</title>");            
            out.println("</head>");
            out.println("<body>");
//            out.println("<h1>Servlet RestfullServlet at " + request.getContextPath() + "</h1>");
                
            rfc = new RestfulClient();
            bm = new ArrayList<>();
            gbm = new GenericType<Collection<Bookmaster>>(){};
            
            //get all record in bookmaster table
            rs = rfc.getAllBooks(Response.class);
            bm = rs.readEntity(gbm);
            
            for(Bookmaster b : bm){
                out.println(b.getBookID()+"  :  "+ b.getBookName()+"<hr/>");
            }
            
            //insert
//               rfc.addBook("polo", "polo", "polo","polo" ); //done
//               rfc.updateBook("10", "abc", "abc", "abc","jhanvi");
//              rfc.removeBook("8"); //done
            
            out.println("<h1>Done..</h1>");
            
            out.println("</body>");
            out.println("</html>");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
