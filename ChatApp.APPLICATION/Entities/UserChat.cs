namespace ChatApp.Application.Entities
{
    public class UserChat
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public string Rol {  get; set; }
        public DateTime JoinedAt { get; set; }


        public User User { get; set; }
        public Chat Chat { get; set; }

        public ICollection<Multimedia> multimedias { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
