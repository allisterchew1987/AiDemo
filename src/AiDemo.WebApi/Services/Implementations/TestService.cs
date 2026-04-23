using AiDemo.WebApi.Services.Interfaces;

namespace AiDemo.WebApi.Services.Implementations;

/// <summary>
/// Implementation of <see cref="ITestService"/>.
/// </summary>
public class TestService : ITestService
{
    /// <inheritdoc />
    public string HelloWorld() => "Hello World";
}
