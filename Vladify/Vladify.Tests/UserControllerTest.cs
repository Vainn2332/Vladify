using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.Controllers;
using Vladify.Options;

namespace Vladify.UnitTests;

public class UserControllerTest
{
    private readonly IFixture _fixture;
    private readonly Mock<IUserService> _userServiceMock;
    private readonly Mock<IOptions<ApiKeysOptions>> _apiKeyOptionsMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UsersController _usersController;

    public UserControllerTest()
    {
        _fixture = new Fixture().Customize(new AutoMoqCustomization());
        _userServiceMock = _fixture.Freeze<Mock<IUserService>>();

        _apiKeyOptionsMock = _fixture.Freeze<Mock<IOptions<ApiKeysOptions>>>();
        _apiKeyOptionsMock.Setup(m => m.Value).Returns(new ApiKeysOptions
        {
            Auth0SyncInDb = "superSecretApiKey"
        });

        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _usersController = new UsersController(_userServiceMock.Object, _mapperMock.Object, _apiKeyOptionsMock.Object);
    }

    [Fact]
    public async Task AddUserAsync_Should_CreateUserInDb_WhenValidApiKey()
    {
        var apiKey = "superSecretApiKey";
        var request = _fixture.Create<UserRequestModel>();
        var userModel = _fixture.Create<UserModel>();
        _userServiceMock.Setup(m => m.AddUserAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userModel);

        var response = await _usersController.CreateUser(request, apiKey);

        response.Should().NotBeNull();
        _userServiceMock.Verify(m => m.AddUserAsync(request, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task AddUserAsync_Should_CreateUnauthorizedException_When_WrongApiKey()
    {
        var request = _fixture.Create<UserRequestModel>();
        var wrongApiKey = "wrongApiKey";

        var act = () => _usersController.CreateUser(request, wrongApiKey);

        await act.Should().ThrowAsync<UnauthorizedException>();
        _userServiceMock.Verify(m => m.AddUserAsync(It.IsAny<UserRequestModel>(), It.IsAny<CancellationToken>()), Times.Never);
    }
}
