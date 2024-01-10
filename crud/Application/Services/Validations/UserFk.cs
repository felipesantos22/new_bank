using crud.Infrastructure.Data;

namespace crud.Application.Services.Validations;

public class UserFk
{
    private readonly DataContext _dataContext;

    public UserFk(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    
    public bool ExistsUserFk(int userId)
    {
        return _dataContext.Deposities.Any(d => d.Id == userId);
    }
}