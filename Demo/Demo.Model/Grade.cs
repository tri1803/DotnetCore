using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Model
{
    // grade for grade model
    public class Grade
    {
        //grade id
        public int Id { get; set; }
        
        //grade name
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
            
        //List<Student>
        public ICollection<Student> Student { get; set; }
    }
}