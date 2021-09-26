using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Podium.Data.Dtos;
using Podium.Data.Entities;
using Podium.Services;
using System;
using System.Threading.Tasks;

namespace Podium.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MortgageController : ControllerBase
    {
        private readonly ILogger<MortgageController> _logger;
        private readonly IMortgageService _mortgageService;
        private readonly IMapper _mapper;

        public MortgageController(ILogger<MortgageController> logger,
            IMortgageService mortgageService,
            IMapper mapper)
        {
            _logger = logger;
            _mortgageService = mortgageService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<MortgageProposal>> PostMortgageProposal(RequestedMortgageRequirementDto requestedRequirment)
        {
            var requirementDto = new MortgageRequirementDto
            {
                Id = new Guid(),
                ApplicantId = requestedRequirment.ApplicantId,
                DepositAmount = requestedRequirment.DepositAmount,
                PropertyValue = requestedRequirment.PropertyValue
            };
            var requirement = _mapper.Map<MortgageRequirement>(requirementDto);
            var proposal = await _mortgageService.CreateProposal(requirement);
            var proposalDto = _mapper.Map<MortgageProposalDto>(proposal);

            return CreatedAtAction("PostMortgageProposal", new { id = proposal.Id }, proposalDto);
        }
    }
}
