class Product {
    public static void main(String[] args) {
        
        String[] productName = { "bread", "milk", "chocolate", "cheese"};
        int[] prices = { 30, 47, 87, 110};
        
        for( int i = 0; i < 4; i++) {
            System.out.println ("Product: " + productName[i]);
            System.out.println ("Price: " + prices[i] + "uah");
        }
        
        
        
    }
}