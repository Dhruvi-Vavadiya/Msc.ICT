//complie time polymorphisam
// package polymorphisam;

/**
 * OverLoading
 */
public class OverLoading {

    int add(){
        int a=10;
        int b=20;
        int c=a+b;
        return  c;
    }
    void add(int a,int b){
        int c=a+b;
        System.out.println(c);
    }
    void add(int x,double y){
        double c=x+y;
        System.out.println(c);
    }

    int add(int n[]){
        int res=1;
        for(int i=0;i<n.length;i++)
        res=res*n[i];
        return res;
        
        
    }
    
    public static void main(String[] args) {
        OverLoading obj=new OverLoading();
        int i=obj.add();
        System.err.println("first method ::"+i);

        System.err.println("second method");
        obj.add(10, 20);

        System.err.println("third method");
        obj.add(10, 20.5);
        
        int n[]={1,2,3,4,5};
        obj.add(n);
        System.out.println(obj.add(n));
    }
}