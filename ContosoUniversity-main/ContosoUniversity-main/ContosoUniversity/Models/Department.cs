using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;

public class Department
{
     
    public int DepartmentID { get; set; }

    [StringLength(50, MinimumLength = 3)]


    [Display(Name = "Nombre")] 
    public string Name { get; set; }
    [Display(Name = "Presupuesto")]

    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Budget { get; set; }
    

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
                   ApplyFormatInEditMode = true)]
    [Display(Name = "Fecha de creación")]
    public DateTime StartDate { get; set; }

    public int? InstructorID { get; set; }

    [Timestamp]
    [Display(Name = "Token")]
    public byte[] ConcurrencyToken { get; set; }

    public Instructor Administrator { get; set; }
    public ICollection<Course> Courses { get; set; }
}
