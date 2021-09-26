using AutoMapper;
using Podium.Data.Dtos;
using Podium.Data.Entities;
using System.Collections.Generic;

namespace Podium.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Applicant, ApplicantDto>().ReverseMap();
            CreateMap<IEnumerable<Applicant>, IEnumerable<ApplicantDto>>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<MortgageRequirement, MortgageRequirementDto>().ReverseMap();
            CreateMap<MortgageProposal, MortgageProposalDto>().ReverseMap();
            CreateMap<MortgageProposalProduct, MortgageProposalProductDto>().ReverseMap();

        }
    }
}
