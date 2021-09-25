using Podium.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Podium.Services
{
    public interface IApplicantService
    {
        Task<IEnumerable<Applicant>> GetAll();
        Task<Applicant> GetById(Guid id);

        Task<Applicant> CreateApplicant(Applicant applicant);

        bool CheckApplicantAge(DateTime dateOfBirth);
    }
}
