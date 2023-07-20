using System;

class Program
{
    static void Main(string[] args)
    {

        Order order = new Order();
        order.setProductList(new Product("Milk", 1, 20, 2));
        order.setProductList(new Product("Sugar", 2, 50, 3));
        order.setProductList(new Product("Chocolate", 3, 100, 1));
        order.setCustomerList(new Customer("Mike", new Address("Av. Marthon", "Los Angles", "California", "USA")));
        ordersList.Add(order);

        Order order2 = new Order();
        order2.setProductList(new Product("Cake", 4, 150, 2));
        order2.setProductList(new Product("Meat", 5, 200, 1));
        order2.setProductList(new Product("Cookies", 6, 25, 5));
        order2.setCustomerList(new Customer("Agustin", new Address("Av. Carlton", "Montevideo", "Montevideo", "Uruguay")));
        ordersList.Add(order2);

        Order order3 = new Order();
        order3.setProductList(new Product("Biscuits", 7, 30, 6));
        order3.setProductList(new Product("Tomatoes", 8, 50, 3));
        order3.setProductList(new Product("Apples", 9, 40, 2));
        order3.setCustomerList(new Customer("Tyler", new Address("Av. Ront", "Las Vegas", "Nevada", "United States")));
        ordersList.Add(order3);

        foreach(Order item in ordersList){
            Console.WriteLine();
            item.packingLabel();
            item.shippingLabel();
            item.comupteTotalOrderPrice();
            Console.WriteLine("--------------------------------------");
        }
    }

    static List<Order> ordersList = new List<Order>();
}