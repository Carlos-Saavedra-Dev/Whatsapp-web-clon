namespace ChatApp.Core.Entities
{
    public class Multimedia
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public DateTime UploadedAt { get; set; }
        public Guid UserChatId { get; set; }

        public UserChat UserChat { get; set; }

    }
}
