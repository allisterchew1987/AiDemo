using AiDemo.WebApi.Services.Implementations;
using FluentAssertions;
using Xunit;

namespace AiDemo.WebApi.Tests.Services;

public class TestServiceTests
{
    private readonly TestService _sut;

    public TestServiceTests()
    {
        _sut = new TestService();
    }

    [Fact]
    public void HelloWorld_ShouldReturnHelloWorldString()
    {
        // Act
        var result = _sut.HelloWorld();

        // Assert
        result.Should().Be("Hello World");
    }

    [Fact]
    public void HelloWorld_ShouldReturnNonNullString()
    {
        // Act
        var result = _sut.HelloWorld();

        // Assert
        result.Should().NotBeNullOrEmpty();
    }
}
