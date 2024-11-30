using ChatApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Infraestructure.Data
{
    public class ChatAppDbContext : DbContext
    {
        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Auth> Auths { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints

            //UserChat
            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.User)
                .WithMany(c => c.UserChats)
                .HasForeignKey(uc => uc.UserId);

            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.Chat)
                .WithMany(c => c.UserChats)
                .HasForeignKey(uc => uc.ChatId);

            //Message
            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.ReplyToMessageId);

            modelBuilder.Entity<Message>()
               .HasOne(m => m.UserChat)
               .WithMany(u => u.Messages)
               .HasForeignKey(m => m.UserChatId);

            //Multimedia
            modelBuilder.Entity<Multimedia>()
                .HasOne(mt => mt.UserChat)
                .WithMany(uc => uc.multimedias)
                .HasForeignKey(mt => mt.UserChatId);

            //Auth 
            modelBuilder.Entity<Auth>()
                .HasOne(at => at.User)
                .WithOne(u => u.Auth)
                .HasForeignKey<Auth>(at => at.UserId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
