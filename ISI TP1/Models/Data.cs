using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ISI_TP1.Models;


public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? _id { get; set; }

    
    public string product_name { get; set; } = null!;

    public string price { get; set; }

    public string stock_quantity { get; set; } = null!;

    public string location { get; set; } = null!;

    public string manufacturer { get; set; } = null!;

    public string expiration_date { get; set; } = null!;

    public string vending_machine_id { get; set; } = null!;

    public string category { get; set; } = null!;



}
