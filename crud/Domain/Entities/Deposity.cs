using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace crud.Domain.Entities;

public class Deposity
{
    public int Id { get; set; }

    public double Value { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; set; }

    [JsonIgnore] 
    public User? User { get; set; }
}