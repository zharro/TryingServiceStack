using System;
using ServiceStack;
using TryingServiceStack.ServiceModel.Dto;

namespace TryingServiceStack.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new JsonHttpClient("http://localhost:8088");
            UserResponse response = client.Get(new User());
            Console.WriteLine(response.FirstName);
        }
    }
}
