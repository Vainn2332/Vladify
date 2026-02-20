using AutoMapper;
using Moq;
using Vladify.BusinessLogic;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;

namespace Vladify.UnitTests;

public class UserServiceTest
{
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UserService _userService;

    public UserServiceTest()
    {
        _userRepositoryMock = new Mock<IUserRepository>();
        _mapperMock = new Mock<IMapper>();
        _userService = new UserService(_userRepositoryMock.Object, _mapperMock.Object);
    }
    [Fact]
    public async Task AddUserAsync_Should_ReturnArgumentException_WithError_UserWithSuchEmailAlreadyExists()
    {
        var emailThatAlreadyExists = "validEmail";
        var request = new UserRequestModel()
        {
            EmailAddress = emailThatAlreadyExists,
            Age = 32,
            Gender = Gender.Female,
            Name = "valid",
            Password = "valid"
        };
        var existingUser = new User()
        {
            Id = Guid.NewGuid(),
            EmailAddress = emailThatAlreadyExists,
            Age = 50,
            Gender = Gender.Male,
            Name = "valid",
            PasswordHash = "validHash"
        };
        _userRepositoryMock.Setup(m => m.GetByEmailAsync(emailThatAlreadyExists, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(existingUser);
        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                _userService.AddUserAsync(request, CancellationToken.None));

        Assert.Equal("User with such email already exists!", exception.Message);

        _userRepositoryMock.Verify(m => m.AddAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task AddUserAsync_Should_ReturnUser()
    {
        Guid userId = Guid.NewGuid();
        var request = new UserRequestModel()
        {
            EmailAddress = "valid",
            Age = 32,
            Gender = Gender.Female,
            Name = "valid",
            Password = "valid"
        };
        var userEntity = new User()
        {
            Id = userId,
            EmailAddress = "valid",
            Age = 32,
            Gender = Gender.Female,
            Name = "valid",
            PasswordHash = "validHash"
        };
        var userModel = new UserModel()
        {
            Id = userId,
            EmailAddress = "valid",
            Age = 32,
            Gender = Gender.Female,
            Name = "valid",
        };
        _mapperMock.Setup(m => m.Map<User>(request))
            .Returns(userEntity);
        _userRepositoryMock.Setup(m => m.AddAsync(userEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(userEntity))
            .Returns(userModel);

        var result = await _userService.AddUserAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(userEntity.Id, result.Id);

        _userRepositoryMock.Verify(m => m.AddAsync(userEntity, It.IsAny<CancellationToken>()), Times.Once);
    }
    [Fact]
    public async Task GetUsersAsync_Should_ReturnUsers()
    {
        var paginationFilter = new PaginationFilter() { PageNumber = 15, PageSize = 2 };
        var userEntityList = new List<User>()
        {
            new()
            {
                Id=Guid.NewGuid(),
                Age=25,
                EmailAddress="validEmail",
                Gender=Gender.Male,
                Name="valid",
                PasswordHash="validHash"
            },
            new()
            {
                Id=Guid.NewGuid(),
                Age=40,
                EmailAddress="validEmail",
                Gender=Gender.Male,
                Name="valid",
                PasswordHash="validHash"
            }
        };
        var userModelList = new List<UserModel>()
        {
            new()
            {
                Id=userEntityList[0].Id,
                Age=25,
                EmailAddress="validEmail",
                Gender=Gender.Male,
                Name="valid",
            },
            new()
            {
                Id=userEntityList[1].Id,
                Age=40,
                EmailAddress="validEmail",
                Gender=Gender.Male,
                Name="valid",
            }
        };
        _userRepositoryMock.Setup(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntityList);
        _mapperMock.Setup(m => m.Map<IEnumerable<UserModel>>(userEntityList))
            .Returns(userModelList);

        var result = await _userService.GetUsersAsync(paginationFilter, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(paginationFilter.PageSize, userModelList.Count);

        _userRepositoryMock.Verify(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }
    [Fact]
    public async Task GetUserById_Should_ReturnUser_WhenFound()
    {
        var userId = Guid.NewGuid();
        var userEntity = new User()
        {
            Id = userId,
            Age = 25,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
            PasswordHash = "validHash"
        };
        var userModel = new UserModel()
        {
            Id = userId,
            Age = 40,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
        };
        _userRepositoryMock.Setup(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(userEntity))
            .Returns(userModel);

        var result = await _userService.GetUserByIdAsync(userId, true, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(result.Id, userId);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetUserById_Should_ReturnNull_When_NotFound()
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
        var invalidUserId = Guid.NewGuid();
        var request = new UserUpdateRequestModel()
        {
            Id = invalidUserId,
            Age = 55,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
            Password = "validString"
        };
        _userRepositoryMock.Setup(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _userService.UpdateUserAsync(request, CancellationToken.None));

        Assert.Equal("User with such id not found!", exception.Message);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdateUserAsync_Should_ReturnUserModel()
    {
        var userId = Guid.NewGuid();
        var request = new UserUpdateRequestModel()
        {
            Id = userId,
            Age = 55,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
            Password = "validString"
        };
        var user = new User()
        {
            Id = userId,
            Age = request.Age,
            EmailAddress = request.EmailAddress,
            Gender = request.Gender,
            Name = request.Name,
            PasswordHash = "validHash"
        };
        var oldUserEntity = new User()
        {
            Id = userId,
            Age = 50,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
            PasswordHash = "validHash"
        };
        var updatedUserEntity = new User()
        {
            Id = userId,
            Age = user.Age,
            EmailAddress = user.EmailAddress,
            Gender = user.Gender,
            Name = user.Name,
            PasswordHash = user.PasswordHash
        };
        var updatedUserModel = new UserModel()
        {
            Id = userId,
            Age = updatedUserEntity.Age,
            EmailAddress = updatedUserEntity.EmailAddress,
            Gender = updatedUserEntity.Gender,
            Name = updatedUserEntity.Name,
        };
        _userRepositoryMock.Setup(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldUserEntity);
        _mapperMock.Setup(m => m.Map<User>(request))
            .Returns(user);
        _userRepositoryMock.Setup(m => m.UpdateAsync(user, It.IsAny<CancellationToken>()))
            .ReturnsAsync(updatedUserEntity);
        _mapperMock.Setup(m => m.Map<UserModel>(updatedUserEntity))
            .Returns(updatedUserModel);

        var result = await _userService.UpdateUserAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(request.Id, result.Id);

        _userRepositoryMock.Verify(m => m.UpdateAsync(user, It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.GetByIdAsync(userId, false, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task DeleteaUserAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var invalidUserId = Guid.NewGuid();
        _userRepositoryMock.Setup(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((User?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _userService.DeleteUserAsync(invalidUserId, CancellationToken.None));

        Assert.Equal("User with such id not found!", exception.Message);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(invalidUserId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteUserAsync_Should_Delete_WhenExists()
    {
        var userId = Guid.NewGuid();
        var userEntity = new User()
        {
            Id = userId,
            Age = 55,
            EmailAddress = "validEmail",
            Gender = Gender.Male,
            Name = "valid",
            PasswordHash = "validHash"
        };
        _userRepositoryMock.Setup(m => m.GetByIdAsync(userId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(userEntity);
        _userRepositoryMock.Setup(m => m.DeleteAsync(userEntity, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _userService.DeleteUserAsync(userId, CancellationToken.None);

        _userRepositoryMock.Verify(m => m.GetByIdAsync(userId, true, It.IsAny<CancellationToken>()), Times.Once);
        _userRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
