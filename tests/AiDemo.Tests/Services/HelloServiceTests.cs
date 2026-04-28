using AiDemo.WebApi.Services.Implementations;
using FluentAssertions;
using Xunit;

namespace AiDemo.Tests.Services;

public class HelloServiceTests
{
    private readonly HelloService _sut = new();

    [Fact]
    public void GetHelloWorld_ReturnsHelloWorldString()
    {
        var result = _sut.GetHelloWorld();

        result.Should().Be("Hello World");
    }

    [Fact]
    public void GetHelloWorld_ReturnsNonNullString()
    {
        var result = _sut.GetHelloWorld();

        result.Should().NotBeNullOrEmpty();
    }
}
