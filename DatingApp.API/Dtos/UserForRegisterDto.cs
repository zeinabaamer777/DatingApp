using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}