using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Vladify.IntegrationTests.Infrastructure;

namespace Vladify.IntegrationTests.Tests.Mapper;

[Collection("FixtureCollection")]
public class MapperTest
{
    private readonly IntegrationTestInfrastructure _testInfrastructure;

    public MapperTest(IntegrationTestInfrastructure integrationTestInfrastructure)
    {
        _testInfrastructure = integrationTestInfrastructure;
    }

    [Fact]
    public void Mapper_Should_ShowConfigurationIsValid()
    {
        var sp = _testInfrastructure.Factory.Services;

        var mapper = sp.GetRequiredService<IMapper>();

        mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}
