// See https://aka.ms/new-console-template for more information
using ProductService;


ProductServiceClient client = new ProductServiceClient();

var product = await client.PostAsync(new Product
{
    Id = 1,
    Name = "Test",
    Price = 1000
});


Console.WriteLine("Hello, World!");