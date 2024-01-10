using crud.Domain.Entities;
using crud.Domain.Interfaces;
using crud.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace crud.Infrastructure.Repository;

public class DeposityRepository: IProduct
{
    private readonly DataContext _dataContext;

    public DeposityRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<Deposity> Create(Deposity deposity)
    {
        await _dataContext.Deposities.AddAsync(deposity);
        await _dataContext.SaveChangesAsync();
        return deposity;
    }

    public async Task<List<Deposity>> Index()
    {
        var depositions = await _dataContext.Deposities.ToListAsync();
        return depositions;
    }

    public Task<Deposity> Show(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Deposity> Update(int id, Deposity deposity)
    {
        throw new NotImplementedException();
    }

    public Task<Deposity> Destroy(int id)
    {
        throw new NotImplementedException();
    }
}