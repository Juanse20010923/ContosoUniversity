using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;

public class Student
{
    public int ID { get; set; }
    [Required]
    [StringLength(50)]
    [Display(Name = "apellido")]
    public string LastName { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
    [Column("FirstName")]
    [Display(Name = "Nombre")]
    public string FirstMidName { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Fecha de ingreso")]
    public DateTime EnrollmentDate { get; set; }
    [Display(Name = "Full Name")]
    public string FullName
    {
        get
        {
            return LastName + ", " + FirstMidName;
        }
    }
    [Display(Name = "Inscripciones")]
    public ICollection<Enrollment> Enrollments { get; set; }
}
