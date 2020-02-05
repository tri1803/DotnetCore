namespace Temp.Service.DTO
{
    public class CreateAccDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPass { get; set; }

        public int RoleId { get; set; }
    }
}