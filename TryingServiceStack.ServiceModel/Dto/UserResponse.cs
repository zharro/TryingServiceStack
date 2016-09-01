using System;

namespace TryingServiceStack.ServiceModel.Dto
{
    public class UserResponse
    {
        public int UserId { get; set; }
        public string Msisdn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedUtc { get; set; }
    }
}