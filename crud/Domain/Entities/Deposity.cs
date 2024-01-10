using System.Text.Json.Serialization;

namespace crud.Domain.Entities;

public class Deposity
{
    public int Id { get; set; }
    
    public double Value { get; set; }
    
    public int? UserId { get; set; } // Optional foreign key property
    
    [JsonIgnore]
    public User? User { get; set; }
}