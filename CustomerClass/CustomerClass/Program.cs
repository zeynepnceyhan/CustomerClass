namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Zeynep";
            customer.LastName = "Ceyhan";
            customer.City = "İzmir";
            customer.Id = 298;

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.City);

            Customer customer2 = new Customer
            {
                Id = 200,
                City = "Ankara",
                FirstName = "Elif",
                LastName = "Ceyhan"
            };
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.City);
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
