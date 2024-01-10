namespace crud.Domain.Entities;

public class User
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    public List<Deposity> Deposities { get; } = new List<Deposity>();
}