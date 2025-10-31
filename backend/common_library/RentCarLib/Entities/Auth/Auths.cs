using System;

namespace RentCarLib.Entities.Auth
{
    public class Auths
    {
        public Guid AuthId { get; set; }
        public Guid UserId { get; set; }
        public Guid? PhoneAuth { get; set; }
        public Guid? EmailAuth { get; set; }
        public Guid? TelegramAuth { get; set; }
    }
}