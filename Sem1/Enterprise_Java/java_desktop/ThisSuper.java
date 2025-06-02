
class EkClass{
    int a;
    
    EkClass(int x){
        a=x;
    }

    public int returnnone(){
        return 5;
    }

    public int getA(){
        return a;
    }
}

public class ThisSuper {
    public static void main(String[] args) {
        EkClass e=new EkClass(5);
    }    
}
