using crud.Domain.Entities;
using crud.Domain.Interfaces;
using crud.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace crud.Infrastructure.Repository;

public class UserRepository: IUser
{
    private readonly DataContext _dataContext;

    public UserRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    public async Task<User> Create(User user)
    {
        await _dataContext.Users.AddAsync(user);
        await _dataContext.SaveChangesAsync();
        return user;
    }

    public async Task<List<User>> Index()
    {
        var user = await _dataContext.Users.Include(d => d.Deposities).ToListAsync();
        return user;
    }

    public async Task<User?> Show(int id)
    {
        var user = await _dataContext.Users.Include(d => d.Deposities).FirstOrDefaultAsync(u => u.Id == id);
        return user;
    }

    public Task<User> Update(int id, User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> Destroy(int id)
    {
        throw new NotImplementedException();
    }
}