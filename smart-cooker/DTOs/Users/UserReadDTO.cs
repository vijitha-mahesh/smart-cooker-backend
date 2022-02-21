namespace smartCooker.DTOs.Users
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public string NIC { get; set; }

        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
