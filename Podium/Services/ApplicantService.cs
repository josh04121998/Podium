using Podium.Data.Entities;
using Podium.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Services
{
    public class ApplicantService  : IApplicantService
    {
        const int MINIMUM_AGE = 18;

        private readonly IApplicantRepository _repository;
        public ApplicantService(IApplicantRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Applicant>> GetAll()
        {
            var applicants = await _repository.GetAllAsync();
            return applicants;
        }

        public async Task<Applicant> GetById(Guid id)
        {
            var applicant = await _repository.GetByIdAsync(id);
            return applicant;
        }

        public async Task<Applicant> CreateApplicant(Applicant applicant)
        {
            var newApplicant = await _repository.CreateAsync(applicant);
            return newApplicant;
        }

        public bool CheckApplicantAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age)) age--;

            return age >= MINIMUM_AGE;
        }
    }
}
