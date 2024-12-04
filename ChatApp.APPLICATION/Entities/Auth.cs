namespace ChatApp.Application.Entities
{
    public class Auth
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public String RefreshToken { get; set; }

        public DateTime ExpiresAt { get; set; }

        public User User { get; set; }
    }
}
