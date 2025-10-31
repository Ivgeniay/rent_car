using System;

namespace RentCarLib.Entities.Auth
{
    public class VerificationCode
    {
        public Guid VerificationCodeld { get; set; }
        public VerificationCodeType Type { get; set; }
        public string For { get; set; } = string.Empty; 
        public string Code { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; } = DateTime.UtcNow;
        public bool IsUsed { get; set; }
        public DateTime? UsedAt { get; set; } = null;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}