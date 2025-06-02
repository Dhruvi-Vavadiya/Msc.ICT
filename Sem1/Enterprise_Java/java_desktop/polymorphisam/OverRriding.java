//run time polymorphisam
// package polymorphisam;


    class shape{
        void draw(){
            System.out.println("class shape");
        }
    }
    class square extends shape{
        @Override
        void draw(){
            // super.draw();
            System.out.println("class square");
        }
    }
    class circle extends shape{
        @Override
        void draw(){
            // super.draw();
            System.out.println("class circle");
        }
    }
public class OverRriding {
    public static void main(String[] args) {
        shape s1=new square();
        s1.draw();

        shape s2=new circle();
        s2.draw();
        
        
    }
}
