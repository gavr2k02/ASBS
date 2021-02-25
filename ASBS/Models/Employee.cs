using System;

namespace ASBS.Models
{
    class Employee
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Speciality { get; set; }

        public Employee(string firstName, string lastName, string tel, string email, string speciality)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Tel = tel ?? throw new ArgumentNullException(nameof(tel));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Speciality = speciality ?? throw new ArgumentNullException(nameof(speciality));
        }
    }
}
