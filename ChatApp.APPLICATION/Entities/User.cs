namespace ChatApp.Application.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }
        public string HashedPassword { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? CreatedAt { get; set; }
        public Auth? Auth { get; set; }

        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<Message> Messages { get; set; }



    }
}
