using System;

namespace RentCarLib.Entities.Users
{
    [Flags]
    public enum Role
    {
        Publisher = 1,
        Renter = 2,
        Moderator = 4,
        Admin = 8,
        SuperModerator = 16
    }
}