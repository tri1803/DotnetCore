using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Model
{
    /// <summary>
    /// Class Role 
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
                
        /// <summary>
        /// List user
        /// </summary>
        public ICollection<User> User { get; set; }
    }
}