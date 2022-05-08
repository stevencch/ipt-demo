namespace Demo.Ipt.IntegrationTest.Controllers;
public class ProposalController: IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly CustomWebApplicationFactory<Program>
        _factory;

    public ProposalController(
        CustomWebApplicationFactory<Program> factory)
    {
        _factory = factory;
        
    }
    [Fact]
    public async Task ProposalControolerTest_Success()
    {
        // Arrange
        var client = _factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        var mapper = config.CreateMapper();
        var initProposals = DataFactory.DefaultDatabaseProposals();
        var expected = initProposals.Select(x => mapper.Map<ProposalModel>(x));
        // Act
        var response = await client.GetAsync(Urls.Proposal.GetData);

        // Assert
        response.EnsureSuccessStatusCode();
        var content =
                await response.Content.ReadAsStringAsync();
        var serializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
        var proposals = JsonSerializer.Deserialize<IEnumerable<ProposalModel>>(content,serializeOptions);

        proposals.Should().BeEquivalentTo(expected);
    }
}
