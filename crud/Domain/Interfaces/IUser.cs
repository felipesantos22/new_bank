using crud.Domain.Entities;

namespace crud.Domain.Interfaces;

public interface IUser
{
    public Task<User> Create(User user);
    public Task<List<User>> Index();
    public Task<User?> Show(int id);
    public Task<User> Update(int id, User user);
    public Task<User> Destroy(int id);
}