public class Product {

    private String _productName;
    private int _id;
    private int _price;
    private int _productAmount;
    public Product (String name, int id, int price, int productAmount){
        _productName = name;
        _id = id;
        _price = price;
        _productAmount = productAmount;
    }

    public String getName(){
        return _productName;
    }
    public int getId(){
        return _id;
    }
    public int getPrice(){
        return _price;
    }
    public int getProductAmount(){
        return _productAmount;
    }



}