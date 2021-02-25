using System;

namespace ASBS.Models
{
    class Client
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public Client(string firstName, string lastName, string tel, string email)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Tel = tel ?? throw new ArgumentNullException(nameof(tel));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Client(string firstName, string lastName, string tel)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Tel = tel ?? throw new ArgumentNullException(nameof(tel));
        }
    }
}
