using System.ComponentModel.DataAnnotations.Schema;

namespace Temp.DataAccess
{
    /// <summary>
    /// Class Product
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Amount { get; set; }

        public int? Price { get; set; }
        
        [Column(TypeName = "ntext")]
        public string Desc { get; set; }
        
        /// <summary>
        /// foreign key categoryid
        /// </summary>
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}