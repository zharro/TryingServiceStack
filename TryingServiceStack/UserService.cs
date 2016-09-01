using System;
using ServiceStack;
using TryingServiceStack.ServiceModel.Dto;

namespace TryingServiceStack
{
    public class UserService : Service
    {
        public object Get(User request)
        {
            return new UserResponse
            {
                UserId = 1,
                FirstName = "Service",
                LastName = "Stack",
                IsEnabled = true,
                Msisdn = "79267778899",
                CreatedUtc = DateTime.UtcNow
            };
        }
    }
}