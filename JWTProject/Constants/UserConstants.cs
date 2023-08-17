using JWTProject.Models;

namespace JWTProject.Constants
{
    public class UserConstants
    {
        public static List<UserModels> Users = new List<UserModels>()
        {
            new UserModels(){Username ="admin",Password="admin",Rol="Administrador", EmailAddress="admin@admin.com", FirstName="Admin", LastName="Second"},
            new UserModels() { Username ="user",Password="user",Rol="Usuario", EmailAddress="user@user.com", FirstName="User", LastName="Second"}
            };
    }
}
