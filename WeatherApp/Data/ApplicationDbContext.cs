using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;

namespace WeatherApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : IdentityDbContext<ApplicationUser, IdentityRole<ObjectId>, ObjectId>(options)
    {
    }
}
