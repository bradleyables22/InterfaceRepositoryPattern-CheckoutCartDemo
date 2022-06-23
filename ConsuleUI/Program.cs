using DemoLib; 

static void Main()
{
    Customer bradley = new Customer();
    bradley = getCustomer();

    Console.WriteLine("An order has come in for customer: " + bradley.Name);
    Console.WriteLine("His order is as follows:");
    Console.WriteLine();
    ExamineCart(bradley);
    SendAndCompleteOrder(bradley);

}

//iterates through the cart and ships differently based on modeltype.
static void SendAndCompleteOrder(Customer customer) {
    foreach (var item in customer.Cart)
    {
        item.ShipItem(customer);
    }
}

//read off customer cart in console
 static void ExamineCart(Customer customer){

    if (customer.Cart == null)
    {
        Console.WriteLine(customer.Name + "'s cart is empty, cancelling order.");
    }
    else
    {
        foreach (var item in customer.Cart)
        {
            Console.WriteLine(item.Title);
            Console.WriteLine(item.GetType().Name);
            Console.WriteLine(OrderStatus(item).ToString());
            Console.WriteLine();
        }
    }
}

//reads off status of specific item
static string OrderStatus(IProduct product) {
    if (!product.HasOrderBeenCompleted)
    {
        return "Status: Incomplete";
    }
    else
    {
        return "Status: Complete";
    }
}

//create dummy customer
 static Customer getCustomer() {

    return new Customer
    {
        Name="Bradley",
        Address="999 Indiana blvd",
        Email = "bradley@email.com",
        Cart = LoadCart()
    };
}

//create dummy products for customer cart
static ICollection<IProduct> LoadCart() {

    List<IProduct> products = new List<IProduct> { 
        new PhysicalProduct(){ 
            Title="Item1",
            HasOrderBeenCompleted=false,
        },
        new DigitalProduct(){
            Title="Item2",
            HasOrderBeenCompleted=false,
        },
        new PhysicalProduct(){
            Title="Item3",
            HasOrderBeenCompleted=false,
        },
        new DigitalProduct(){
            Title="Item4",
            HasOrderBeenCompleted=false,
        },
    };
    return products;
}

Main();