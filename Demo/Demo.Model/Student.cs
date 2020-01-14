using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Model
{
    //Student for student model
    public class Student
    {
        //Student id
        public int Id { get; set; }
        
        //Student name
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        
        //student age
        public int? Age { get; set; }
        
        //student address
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        
        //foreign key is gradeid 
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
    }
}