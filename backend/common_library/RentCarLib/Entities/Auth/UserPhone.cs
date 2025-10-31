using System;

namespace RentCarLib.Entities.Auth
{
    public class UserPhone
    {
        public Guid UserPhoneId { get; set; }
        public Guid UserId { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public DateTime? VerifiedAt { get; set; } = null;
    }
}