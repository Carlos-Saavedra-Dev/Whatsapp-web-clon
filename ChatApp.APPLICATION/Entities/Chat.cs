namespace ChatApp.Application.Entities
{ 
    public class Chat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool isGroup { get; set; }
        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<UserChat> UserChats { get; set; }
    }
}
