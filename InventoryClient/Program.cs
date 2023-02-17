using Grpc.Net.Client;
using InventoryAPI;
using System.Text.Json;
//using Product;

Console.WriteLine("Teste gRPC");

var channel = GrpcChannel.ForAddress("https://localhost:7117");
var client = new ProductCatalog.ProductCatalogClient(channel); ;

var request = new ProductDetailsRequest
{
    Id = 1,
};

var response = await client.GetProductDetailsAsync(request);

Console.WriteLine(JsonSerializer.Serialize(response, new JsonSerializerOptions
{
    WriteIndented = true
}));

Console.ReadKey();