using System;

namespace RentCarLib.Entities.Auth
{
    public class UserEmail
    {
        public Guid UserEmaild { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public DateTime? VerifiedAt { get; set; } = null;
    }
}