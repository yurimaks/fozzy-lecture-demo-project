namespace WebDemo;

public interface IUserRepository
{
    ICollection<UserEntity> GetAll();
    UserEntity AddUser(string name, int age);
}

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ICollection<UserEntity> GetAll()
    {
        return _dbContext.Users.ToList();
    }

    public UserEntity AddUser(string name, int age)
    {
        var user = new UserEntity
        {
            Name = name,
            Age = age
        };

        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return user;
    }
}