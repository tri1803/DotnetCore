using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Model
{
    /// <summary>
    /// class User
    /// </summary>
    public class User
    {
        /// <summary>
        /// properties
        /// </summary>
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
        
        /// <summary>
        /// foreign key User
        /// </summary>
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}