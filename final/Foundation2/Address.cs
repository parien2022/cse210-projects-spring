public class Address {

    private String _streetAddress;
    private String _city;
    private String _state;
    private String _country;
    private bool _inUSA;
    public Address (String streetAddress, String city, String state, String country){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    }

    public String getCompleteAddress(){
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public bool getIsUSA(){
        if (_country == "USA" || _country == "EE.UU" || _country == "United States"){
            _inUSA = true;
        }else{
            _inUSA = false;
        }
        return _inUSA;
    }


}