using System;

namespace TryingServiceStack.Dto
{
    public class UserResponse
    {
        public string UserId { get; set; }
        public string Msisdn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}