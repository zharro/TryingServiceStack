using Funq;
using ServiceStack;

namespace TryingServiceStack
{
    public class ServiceHost : AppHostBase
    {
        public ServiceHost() : base("UserService host", typeof(UserService).Assembly)
        {
        }

        /// <summary>
        /// Configure the given container with the 
        ///             registrations provided by the funqlet.
        /// </summary>
        /// <param name="container">Container to register.</param>
        public override void Configure(Container container)
        {
        }
    }
}