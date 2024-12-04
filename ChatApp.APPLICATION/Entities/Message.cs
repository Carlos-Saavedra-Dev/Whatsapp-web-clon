namespace ChatApp.Application.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid UserChatId { get; set; }
        public string Content { get; set; }
        public DateTime? SentAt { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? ReplyToMessageId {  get; set; }

        public UserChat UserChat { get; set; }
        public User? User { get; set; }


    }
}
