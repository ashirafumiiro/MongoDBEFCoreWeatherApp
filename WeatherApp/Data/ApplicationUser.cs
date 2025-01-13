using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace WeatherApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<ObjectId>
    {
    }

}
