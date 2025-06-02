public class ForEach {
    public static void main(String[] args) {
        
        int arr[]={1,0,5,0};

        int res=1;
        

        for(int i:arr){
            if(i==0)
                continue;
            res=res*i;
        }
        System.out.printf("%5d",res);
    }
}
