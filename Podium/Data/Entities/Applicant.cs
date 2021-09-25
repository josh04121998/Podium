using System;

namespace Podium.Data.Entities
{
    public class Applicant
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
