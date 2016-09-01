using ServiceStack;

namespace TryingServiceStack.ServiceModel.Dto
{
    [Route("/user", "GET", Summary = "User Service", Notes = "Toy service example")]
    public class User : IReturn<UserResponse>
    {
        /// <summary>
        /// Profile id
        /// </summary>
        [ApiMember(Name = nameof(ProfileId), Description = "Profile id", ParameterType = "query", DataType = "string", IsRequired = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [ApiMember(Name = nameof(Msisdn), Description = "Phone number", ParameterType = "query", DataType = "string", IsRequired = false)]
        public string Msisdn { get; set; }
    }
}