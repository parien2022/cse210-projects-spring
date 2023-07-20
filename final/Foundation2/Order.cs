public class Order {

    private List<Product> _productsList = new List<Product>();
    private List<Customer> _customersList = new List<Customer>();
    public Order(){

    }

    public void setProductList (Product product){
        _productsList.Add(product);
    }

    public List<Product> getProductList (){
        return _productsList;
    }

    public void setCustomerList (Customer customer){
        _customersList.Add(customer);
    }

    public List<Customer> getCustomerList (){
        return _customersList;
    }

    public void packingLabel(){
        foreach(Product item in getProductList()){
            Console.WriteLine($"Product: {item.getName()}      ID: {item.getId()}");
        }
    }

    public void shippingLabel(){
        foreach(Customer item in _customersList){
            Console.WriteLine($"Costumer: {item.getCustomerName()}");
            Console.WriteLine($"Address: {item.getAddress()}");
        }
        
    }

    public void comupteTotalOrderPrice(){
        int productsCost = 0;
        int shippingCost = 5;

        foreach(Product item in getProductList()){
            productsCost = productsCost + item.getPrice() * item.getProductAmount();
        }

        if(_customersList[0].checkIfLiveinUSA()){
            shippingCost = 35;
        }

        Console.WriteLine($"\nThe total price of the order is: ${productsCost + shippingCost}");
    }

}