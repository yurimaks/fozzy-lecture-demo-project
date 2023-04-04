using Moq;
using WebDemo.Controllers;

namespace WebDemo.UnitTests;

public class UnitTest1
{
    [Fact]
    public void UserRepositoryGetAllTests()
    {
        //Arrange
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(x => x.GetAll()).Returns(new List<UserEntity>
        {
            new UserEntity
            {
                Id = 10,
                Name = "Yuri",
                Age = 31
            }
        });
        var controller = new UsersController(userRepository.Object);

        //Act
        var result = controller.GetAll();

        Assert.Equal(1, result.Count);
        Assert.Equal("Yuri", result.First().Name);
    }
}