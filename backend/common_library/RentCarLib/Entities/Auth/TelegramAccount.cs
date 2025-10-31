using System;

namespace RentCarLib.Entities.Auth
{
    public class TelegramAccount
    {
        public Guid TelegramAccountld { get; set; }
        public Guid UserId { get; set; }
        public long TelegramId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime LinkedAt { get; set; } = DateTime.UtcNow;
    }
}