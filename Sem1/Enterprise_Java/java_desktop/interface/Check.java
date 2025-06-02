// package interface;
/**
 * customerraj
 */
interface customerraj {
    int amt =5;
    void purchase();
    
}
class sellersanju implements customerraj{
    @Override
    public void purchase(){
        //  amt=7; //final
        System.out.println("raj needs "+amt+"kg rice");
    }
}


public class Check {
    public static void main(String[] args) {
        customerraj c=new sellersanju();
        c.purchase();
        System.out.println(customerraj.amt);
    }
}
