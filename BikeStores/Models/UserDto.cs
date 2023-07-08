namespace BikeStoresApi.Models
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }   
    }
    public class UserRegisterDto : UserDto { }
    public class UserLoginDto : UserDto { }
}
