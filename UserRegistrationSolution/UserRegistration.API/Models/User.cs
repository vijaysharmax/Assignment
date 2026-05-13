namespace UserRegistration.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Email { get; set; }

        public string ContactNo { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public string? Hobbies { get; set; }

        public string? PhotoPath { get; set; }

        public bool IsTermsAccepted { get; set; }

        public State State { get; set; }

        public City City { get; set; }
    }
}
