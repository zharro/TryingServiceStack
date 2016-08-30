using System;
using ServiceStack;
using TryingServiceStack.Dto;

namespace TryingServiceStack
{
    public class UserService : Service
    {
        public object Get(User request)
        {
            return new UserResponse
            {
                FirstName = "Service",
                LastName = "Stack",
                IsEnabled = true,
                Msisdn = "79267778899",
                CreatedUtc = DateTime.UtcNow
            };
        }
    }
}