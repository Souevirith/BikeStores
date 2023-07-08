namespace BikeStoresApi.Dtos
{
    public class UserDtos
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
    public class UserRegissterDto : UserDtos { }
    public class UserLoginDto : UserDtos { }
}
