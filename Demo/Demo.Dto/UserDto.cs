using Demo.Model;

namespace Demo.Dto
{
    /// <summary>
    /// Class User DTO
    /// </summary>
    public class UserDto
    {       
        /// <summary>
        /// variables
        /// </summary>
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}