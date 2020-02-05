﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Temp.DataAccess
{
    /// <summary>
    /// Class User
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
        
        /// <summary>
        /// Foreign key RoleId
        /// </summary>
        public int RoleId { get; set; }
        
        public Role Role { get; set; }
    }
}