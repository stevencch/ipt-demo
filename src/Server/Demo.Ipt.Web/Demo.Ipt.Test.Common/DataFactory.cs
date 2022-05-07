namespace Demo.Ipt.Test.Common
{
    public static class DataFactory
    {
        public static IEnumerable<Proposal> DefaultDatabaseProposals()
        {
            return new[]
            {
                new Proposal
                {
                    Id = 1,
                    ProposalName = "proposal1",
                    CustomerGrpName = "CustomerGrpName1",
                    Date = Constants.DefaultDateTimeForTesting,
                    Description = "Detailed description1",
                    DateCreated = Constants.DefaultDateTimeForTesting,
                    DateModified = Constants.DefaultDateTimeForTesting,
                    Status = new ProposalStatus
                    {
                        Id = 1,
                        Status = "In Preparation",
                        DateCreated = Constants.DefaultDateTimeForTesting,
                        DateModified = Constants.DefaultDateTimeForTesting,
                    },
                    Facilities = new[]
                    {
                        new Facility
                        {
                            Id=1,
                            FacilityName="Facility1",
                            StartDate=Constants.DefaultDateTimeForTesting,
                            MaturityDate=Constants.DefaultDateTimeForTesting,
                            Limit=1000000000,
                            DateCreated = Constants.DefaultDateTimeForTesting,
                            DateModified = Constants.DefaultDateTimeForTesting,
                            BookingCountry=new Country
                            {
                                Currency="AUD",
                                Name="Australia",
                                DateCreated = Constants.DefaultDateTimeForTesting,
                                DateModified = Constants.DefaultDateTimeForTesting,
                            }
                        },
                        new Facility
                        {
                            Id=2,
                            FacilityName="Facility2",
                            StartDate=Constants.DefaultDateTimeForTesting,
                            MaturityDate=Constants.DefaultDateTimeForTesting,
                            Limit=1000000000,
                            DateCreated = Constants.DefaultDateTimeForTesting,
                            DateModified = Constants.DefaultDateTimeForTesting,
                            BookingCountry=new Country
                            {
                                Currency="AUD",
                                Name="Australia",
                                DateCreated = Constants.DefaultDateTimeForTesting,
                                DateModified = Constants.DefaultDateTimeForTesting,
                            }
                        }
                    }
                },
                new Proposal
                {
                    Id = 2,
                    ProposalName = "proposal2",
                    CustomerGrpName = "CustomerGrpName2",
                    Date = Constants.DefaultDateTimeForTesting,
                    Description = "Detailed description2",
                    DateCreated = Constants.DefaultDateTimeForTesting,
                    DateModified = Constants.DefaultDateTimeForTesting,
                    Status = new ProposalStatus
                    {
                        Id = 2,
                        Status = "Approved",
                        DateCreated = Constants.DefaultDateTimeForTesting,
                        DateModified = Constants.DefaultDateTimeForTesting,
                    },
                }
            };
        }
    }
}
