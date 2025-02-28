
using Assignment_Session_3_EF_Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Assignment_Session_1_EF_Core.Models
{
    //Model : Poco Class [Plaing Old CLR Object] - Domain Entity
    [Table("Students")]
    internal class Student
    {
        //#region By Convention


        //public int Id { get; set; } 


        //public string? FName { get; set; }


        //public string? LName { get; set; }

        //public string? Address { get; set; }

        //public int Age { get; set; }

        ////Foreign Key 
        //public int StudentDepartmentId { get; set; }

        ////Navigation Property : [One]
        //[InverseProperty(nameof(Department.Students))]  
        //public Department? StudentDepartment { get; set; }

        //#endregion

        #region By Data Annotation

        [Key]
        public int Id { get; set; }

        [Required]
        [Column("StudentFirstName", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)]

        public string FName { get; set; } = null!;

        [Required]
        [Column("StudentLastName", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)]
        public string LName { get; set; } = null!;
 
        [Required]
        [Column("StudentAddress", TypeName = "VarChar")]
        [StringLength(50, MinimumLength = 3)] 
        public string? Address { get; set; }
     

        [DeniedValues(40, 45, 50)] 
        public int Age { get; set; }

        //Navigation Property For Stud_Courses Table [Many]
        public virtual ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();

        #endregion
    }
}
