using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models;

public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{

    public int EnrollmentID { get; set; }
    [Display(Name = "Titulo")]
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    [DisplayFormat(NullDisplayText = "No grade")]
    [Display(Name = "Grado")]
    public Grade? Grade { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
}
