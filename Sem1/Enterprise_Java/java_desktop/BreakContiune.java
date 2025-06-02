class BreakContiune{
    public static void main(String[] args) {
        
        for(int i=1;i<=100;i++){
            if(i%10==0)
                continue;

            // if(i==10)
            //     break;
            System.out.printf("%5d ",i);
        }
    }

}