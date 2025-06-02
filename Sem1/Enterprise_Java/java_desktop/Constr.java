//Constructor

public class Constr {
    int x;
    String nm;

    public Constr(int x1,String nm1){
        x=x1;
        nm=nm1;
    }

    public static void main(String[] args) {
        Constr myObj=new Constr(2,"sd");
        System.out.println(myObj.x+" "+myObj.nm);
    }
}

//Object Example

// public class Constr {
//     int x = 5;
  
//     public static void main(String[] args) {
//         Constr myObj = new Constr();
//       System.out.println(myObj.x);
//     }
//   }
