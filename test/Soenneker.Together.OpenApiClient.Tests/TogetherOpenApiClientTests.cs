using Soenneker.Tests.HostedUnit;

namespace Soenneker.Together.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TogetherOpenApiClientTests : HostedUnitTest
{
    public TogetherOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
