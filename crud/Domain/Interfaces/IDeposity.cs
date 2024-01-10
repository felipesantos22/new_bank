using crud.Domain.Entities;

namespace crud.Domain.Interfaces;

public interface IProduct
{
    public Task<Deposity> Create(Deposity deposity);
    public Task<List<Deposity>> Index();
    public Task<Deposity> Show(int id);
    public Task<Deposity> Update(int id, Deposity deposity);
    public Task<Deposity> Destroy(int id);
}