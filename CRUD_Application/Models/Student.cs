using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Application.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter your name")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter your Phone Number")]
        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
    }
}
