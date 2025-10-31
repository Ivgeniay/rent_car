using System;

namespace RentCarLib.Entities.Auth
{
    public class RefreshToken
    {
        public Guid RefreshTokenId { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ExpiresAt { get; set; } = DateTime.UtcNow;
        public DateTime? RevokedAt { get; set; } = null;
        public bool IsRevoked { get; set; } = false;
    }
}