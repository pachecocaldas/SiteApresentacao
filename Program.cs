// See https://aka.ms/new-console-template for more information

var customer = new Customer();
customer.name = "Luis";
Console.WriteLine(customer.name);

 class Customer{
    public int MyProperty { get; set; }
}