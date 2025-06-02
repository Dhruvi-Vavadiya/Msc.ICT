/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author Planet
 */
public class conditional_navigationTest {
    
    public conditional_navigationTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
    }
    
    @AfterAll
    public static void tearDownClass() {
    }
    
    @BeforeEach
    public void setUp() {
    }
    
    @AfterEach
    public void tearDown() {
    }

    /**
     * Test of isAdmin method, of class conditional_navigation.
     */
    @Test
    public void testIsAdmin() {
        System.out.println("isAdmin");
        conditional_navigation instance = new conditional_navigation();
        boolean expResult = false;
        boolean result = instance.isAdmin();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setAdmin method, of class conditional_navigation.
     */
    @Test
    public void testSetAdmin() {
        System.out.println("setAdmin");
        boolean admin = false;
        conditional_navigation instance = new conditional_navigation();
        instance.setAdmin(admin);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setType method, of class conditional_navigation.
     */
    @Test
    public void testSetType() {
        System.out.println("setType");
        int type = 0;
        conditional_navigation instance = new conditional_navigation();
        instance.setType(type);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getType method, of class conditional_navigation.
     */
    @Test
    public void testGetType() {
        System.out.println("getType");
        conditional_navigation instance = new conditional_navigation();
        int expResult = 0;
        int result = instance.getType();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
