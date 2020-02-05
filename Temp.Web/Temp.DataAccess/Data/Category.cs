using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Temp.DataAccess
{
    /// <summary>
    /// Category
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        
        /// <summary>
        /// List Product
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}