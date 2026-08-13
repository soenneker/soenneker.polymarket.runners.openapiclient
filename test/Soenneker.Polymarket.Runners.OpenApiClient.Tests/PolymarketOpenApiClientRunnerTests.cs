using Soenneker.Tests.HostedUnit;

namespace Soenneker.Polymarket.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PolymarketOpenApiClientRunnerTests : HostedUnitTest
{
    public PolymarketOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
