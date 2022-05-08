using Microsoft.Extensions.Logging;

namespace Demo.Ipt.Test.Services;
public class ProposalServiceTest:IClassFixture<ProposalSeedDataFixture>
{
    ProposalSeedDataFixture fixture;

    public ProposalServiceTest(ProposalSeedDataFixture fixture)
    {
        this.fixture = fixture;
    }
    [Fact]
    public async Task GetProposalsAsync_With_Facilities_Success()
    {
        //arrange
        var proposalQueryMock = new Mock<IProposalQuery>();
        var proposalRepository = new ProposalRepository(fixture.IptDbContext);
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        var mapper = config.CreateMapper();
        var loggerMock = new Mock<ILogger<ProposalService>>();
        var proposalService = new ProposalService(proposalRepository, proposalQueryMock.Object, mapper, loggerMock.Object);
        //act
        var proposals = await proposalService.GetProposalsAsync();
        //assert
        proposals.Should().HaveCount(2);
        proposals.Should().Contain(x => x.ProposalId == 1);
        proposals.First(x => x.ProposalId == 1).Facilities.Should().HaveCount(2);
    }

    [Fact]
    public async Task GetProposalsAsyn_Without_Facilities_Success()
    {
        //arrange
        var proposalQueryMock = new Mock<IProposalQuery>();
        var proposalRepository = new ProposalRepository(fixture.IptDbContext);
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        var mapper = config.CreateMapper();
        var loggerMock = new Mock<ILogger<ProposalService>>();
        var proposalService = new ProposalService(proposalRepository, proposalQueryMock.Object, mapper, loggerMock.Object);
        //act
        var proposals = await proposalService.GetProposalsAsync();
        //assert
        proposals.Should().HaveCount(2);
        proposals.Should().Contain(x => x.ProposalId == 2);
        proposals.First(x => x.ProposalId == 2).Facilities.Should().HaveCount(0);
    }

    [Fact]
    public async Task GetProposalsFromRawAsync_With_Facilities_Success()
    {
        //arrange
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        var mapper = config.CreateMapper();
        var proposalQueryMock = new Mock<IProposalQuery>();
        var initProposals = DataFactory.DefaultDatabaseProposals();
        var proposalResults = initProposals.Select(x => mapper.Map<ProposalModel>(x));
        proposalQueryMock.Setup(lib => lib.GetProposalsAsync(CancellationToken.None)).Returns(Task.FromResult(proposalResults));
        var proposalRepositoryMock = new Mock<IProposalRepository>();
        var loggerMock = new Mock<ILogger<ProposalService>>();
        var proposalService = new ProposalService(proposalRepositoryMock.Object, proposalQueryMock.Object, mapper, loggerMock.Object);
        //act
        var proposals = await proposalService.GetProposalsFromRawAsync();
        //assert
        proposals.Should().HaveCount(2);
        proposals.Should().Contain(x => x.ProposalId == 1);
        proposals.First(x => x.ProposalId == 1).Facilities.Should().HaveCount(2);
    }

    [Fact]
    public async Task GetProposalsFromRawAsyn_Without_Facilities_Success()
    {
        //arrange
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        var mapper = config.CreateMapper();
        var proposalQueryMock = new Mock<IProposalQuery>();
        var initProposals = DataFactory.DefaultDatabaseProposals();
        var proposalResults = initProposals.Select(x => mapper.Map<ProposalModel>(x));
        proposalQueryMock.Setup(lib => lib.GetProposalsAsync(CancellationToken.None)).Returns(Task.FromResult(proposalResults));
        var proposalRepositoryMock = new Mock<IProposalRepository>();
        var loggerMock = new Mock<ILogger<ProposalService>>();
        var proposalService = new ProposalService(proposalRepositoryMock.Object, proposalQueryMock.Object, mapper, loggerMock.Object);
        //act
        var proposals = await proposalService.GetProposalsFromRawAsync();
        //assert
        proposals.Should().HaveCount(2);
        proposals.Should().Contain(x => x.ProposalId == 2);
        proposals.First(x => x.ProposalId == 2).Facilities.Should().HaveCount(0);
    }

}
