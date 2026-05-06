using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using Moq;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.BusinessLogic.Services;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests;

namespace Vladify.UnitTests;

public class UserServiceTest
{
    private readonly IFixture _fixture;
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mock<IAuth0Service> _authServiceMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UserService _userService;

    public UserServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());
        _userRepositoryMock = _fixture.Freeze<Mock<IUserRepository>>();
        _authServiceMock = _fixture.Freeze<Mock<IAuth0Service>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _userService = _fixture.Create<UserService>();
    }

    [Fact]
    public async Task AddUserAsync_Should_ReturnArgumentException_WithError_UserWithSuchEmailAlreadyExists()
    {
        var request = _fixture.Create<UserRequestModel>();
        var existingUser = _fixture.Create<User>();
        _userRepositoryMock.Setup(m => m.GetByEmailAsync(request.EmailAddress, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUser);

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                _userService.AddUserAsync(request, CancellationToken.None));

        Assert.Equal("User with such email already exists!", exception.Message);

        _userRepositoryMock.Verify(m => m.AddAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task AddUserAsync_Should_ReturnUser_WhenOk()
    {
        var request = _fixture.Create<UserRequestModel>();
        var userEntity = _fixture.Create<User>();
        var expectedModel = _fixture.Create<UserModel>();
        _userRepositoryMock.Setup(m => m.GetByEmailAsync(request.EmailAddress, false, It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);
        _mapperMock.Setup(m => m.Map<User>(request))
            .Returns(userEntity);
        _userRepositoryMock.Setup(m => m.AddAsync(userEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(userEntity))
            .Returns(expectedModel);

        var result = await _userService.AddUserAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<UserModel>(result);

        _userRepositoryMock.Verify(m => m.AddAsync(userEntity, It.IsAny<CancellationToken>()), Times.Once);
    }
    [Fact]
    public async Task GetUsersAsync_Should_ReturnUsers_WhenOk()
    {
        var paginationFilter = _fixture.Create<PaginationFilter>();
        var userEntityList = _fixture.CreateMany<User>(paginationFilter.PageSize);
        var expectedModels = _fixture.CreateMany<UserModel>(paginationFilter.PageSize);
        _userRepositoryMock.Setup(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntityList);
        _mapperMock.Setup(m => m.Map<IEnumerable<UserModel>>(userEntityList))
            .Returns(expectedModels);

        var result = await _userService.GetUsersAsync(paginationFilter, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(paginationFilter.PageSize, expectedModels.Count());

        _userRepositoryMock.Verify(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }
    [Fact]
    public async Task GetUserByIdAsync_Should_ReturnUser_WhenFound()
    {
        var userEntity = _fixture.Create<User>();
        var expectedModel = _fixture.Create<UserModel>();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(userEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(userEntity))
            .Returns(expectedModel);

        var result = await _userService.GetUserByIdAsync(userEntity.Id, true, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<UserModel>(result);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(userEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetUserByIdAsync_Should_ReturnNull_When_NotFound()
    {
        var invalidUserId = Guid.NewGuid();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);
        _mapperMock.Setup(m => m.Map<UserModel>(null))
            .Returns((UserModel)null!);

        var result = await _userService.GetUserByIdAsync(invalidUserId, true, CancellationToken.None);

        Assert.Null(result);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateUserAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var requesterId = Guid.NewGuid();
        var request = _fixture.Create<UserUpdateRequestModel>();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _userService.UpdateUserAsync(request, requesterId, CancellationToken.None));

        Assert.Equal("User with such id not found!", exception.Message);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdateUserAsync_Should_ReturnUserModel_WhenOk()
    {
        var request = _fixture.Create<UserUpdateRequestModel>();
        var requestEntity = _fixture.Create<User>();
        var oldUserEntity = _fixture.Create<User>();
        oldUserEntity.Id = requestEntity.Id;
        var updatedUserEntity = _fixture.Create<User>();
        var updatedUserModel = _fixture.Create<UserModel>();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldUserEntity);
        _mapperMock.Setup(m => m.Map<User>(request))
            .Returns(requestEntity);
        _userRepositoryMock.Setup(m => m.UpdateAsync(requestEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(updatedUserEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(updatedUserEntity))
            .Returns(updatedUserModel);

        var result = await _userService.UpdateUserAsync(request, requestEntity.Id, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<UserModel>(result);

        _userRepositoryMock.Verify(m => m.UpdateAsync(requestEntity, It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, false, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task DeleteUserAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var requesterId = Guid.NewGuid();
        var invalidUserId = Guid.NewGuid();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _userService.DeleteUserAsync(invalidUserId, requesterId, CancellationToken.None));

        Assert.Equal("User with such id not found!", exception.Message);

        _authServiceMock.Verify(m => m.DeleteUserFromAuth0Async(It.IsAny<string>()), Times.Never);
        _userRepositoryMock.Verify(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteUserAsync_Should_Delete_WhenExists()
    {
        var userEntity = _fixture.Create<User>();

        _userRepositoryMock.Setup(m => m.GetByIdAsync(userEntity.Id, false, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);

        _userRepositoryMock.Setup(m => m.DeleteAsync(userEntity, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _userService.DeleteUserAsync(userEntity.Id, userEntity.Id, CancellationToken.None);

        _authServiceMock.Verify(m => m.DeleteUserFromAuth0Async(userEntity.ExternalId), Times.Once);
        _userRepositoryMock.Verify(m => m.GetByIdAsync(userEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateUserAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        var requesterId = Guid.NewGuid();
        var request = _fixture.Create<UserUpdateRequestModel>();
        var targetUserEntity = _fixture.Create<User>();
        targetUserEntity.Id = request.Id;

        _userRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, false, It.IsAny<CancellationToken>()))
            .ReturnsAsync(targetUserEntity);

        var act = async () => await _userService.UpdateUserAsync(request, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>()
            .WithMessage("You don't have permissions to modify this user!");

        _userRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteUserAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        var requesterId = Guid.NewGuid();
        var targetUserId = Guid.NewGuid();
        var targetUserEntity = _fixture.Create<User>();
        targetUserEntity.Id = targetUserId;

        _userRepositoryMock.Setup(m => m.GetByIdAsync(targetUserId, false, It.IsAny<CancellationToken>()))
            .ReturnsAsync(targetUserEntity);

        var act = async () => await _userService.DeleteUserAsync(targetUserId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>()
            .WithMessage("You don't have permissions to modify this user!");

        _userRepositoryMock.Verify(m => m.GetByIdAsync(targetUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);

        _authServiceMock.Verify(m => m.DeleteUserFromAuth0Async(It.IsAny<string>()), Times.Never);
        _userRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }
}
