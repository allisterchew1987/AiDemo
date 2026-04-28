using AiDemo.WebApi.Services.Implementations;
using FluentAssertions;
using Xunit;

namespace AiDemo.Tests.Services;

public class HelloWorldServiceTests
{
    private readonly HelloWorldService _sut = new();

    [Fact]
    public void GetHelloWorld_ShouldReturnHelloWorldString()
    {
        // Act
        var result = _sut.GetHelloWorld();

        // Assert
        result.Should().Be("Hello World");
    }

    [Fact]
    public void GetHelloWorld_ShouldReturnNonEmptyString()
    {
        // Act
        var result = _sut.GetHelloWorld();

        // Assert
        result.Should().NotBeNullOrEmpty();
    }
}
