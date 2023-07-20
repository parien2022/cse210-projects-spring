public class Customer {

    private String _customerName;
    private Address _Address;

    public Customer(String customerName, Address address){
        _customerName = customerName;
        _Address = address;
    }

    public String getCustomerName(){
        return _customerName;
    }

    public String getAddress(){
        return _Address.getCompleteAddress();
    }

    public bool checkIfLiveinUSA(){
        return _Address.getIsUSA();
    }



}