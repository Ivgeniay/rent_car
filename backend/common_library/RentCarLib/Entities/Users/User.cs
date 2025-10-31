using System;

namespace RentCarLib.Entities.Users
{
    public class User
    {
        public Guid UserId { get; set; }
        public Role Role { get; set; } = Role.Publisher | Role.Renter;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }
        public string? DeleteReason { get; set; } 
        public Guid? DeletedBy { get; set; }
    }
}