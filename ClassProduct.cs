namespace SystemProducts
{
 class Product
        {
            public string Name { get; set; }
            public float Price { get; set; }

            public int Quantity { get; set; }
            public List<string> Clients { get; set; }

            public Product(string name, float price, int quantity, List<string> clients)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Clients = clients;
            }
        }
}