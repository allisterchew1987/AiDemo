using AiDemo.WebApi.Services.Implementations;
using FluentAssertions;
using Xunit;

namespace AiDemo.Tests.Services;

public class TestServiceTests
{
    [Fact]
    public void HelloWorld_ReturnsHelloWorldString()
    {
        var service = new TestService();

        var result = service.HelloWorld();

        result.Should().Be("Hello World");
    }
}
