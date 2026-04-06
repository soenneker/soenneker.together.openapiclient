using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Together.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class TogetherOpenApiClientTests : FixturedUnitTest
{
    public TogetherOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
