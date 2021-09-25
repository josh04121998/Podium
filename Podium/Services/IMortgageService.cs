using Podium.Data.Entities;
using System;
using System.Threading.Tasks;

namespace Podium.Services
{
    public interface IMortgageService
    {
        Task<MortgageProposal> GetById(Guid id);

        Task<MortgageProposal> CreateProposal(MortgageRequirement requirement);
    }
}
